using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MongoDB.Bson;
using MongoDB.Driver;
using static MongoDB.Driver.WriteConcern;

namespace AccurateRecipeRecordingandCalculationSoftware
{
    public partial class recipeCreation : Form
    {
        public recipeCreation()
        {
            InitializeComponent();
        }

        private List<Ingredient> ReadDataIntoIngredient()
        {
            var ingredientList = new List<Ingredient>();
            foreach (DataGridViewRow row in ingredientDatagrid1.Rows)
            {

                if (row.IsNewRow) continue;

                string Name = row.Cells["ingredientName"].Value?.ToString() ?? string.Empty;
                string Preparation = row.Cells["ingredientPreparation"].Value?.ToString() ?? string.Empty;
                int Amount = Convert.ToInt16(row.Cells["ingredientAmount"].Value ?? 0);
                string unit = row.Cells["ingredientUnit"].Value?.ToString() ?? string.Empty;
                decimal Cost = Convert.ToDecimal(row.Cells["ingredientCost"].Value ?? 0);

                var ingredient = new Ingredient(Name, Preparation, Amount, unit, Cost);

                ingredientList.Add(ingredient);

            }
            return ingredientList;
        }
        private List<CookingStep> ReadDataIntoCookingSteps()
        {
            var cookingStepList = new List<CookingStep>();

            foreach (DataGridViewRow row in cookingStepGrid.Rows)
            {

                if (row.IsNewRow) continue;
                TimeSpan stepTime = TimeSpan.Zero;

                int StepNumber = Convert.ToInt16(row.Cells["cookingStepNumber"].Value ?? 0);
                string StepInfo = row.Cells["cookingStepInstructions"].Value?.ToString() ?? string.Empty;
       
                string stepTimeString = row.Cells["cookingStepTime"].Value?.ToString();
                if (!string.IsNullOrWhiteSpace(stepTimeString) && TimeSpan.TryParse(stepTimeString, out TimeSpan parsedTime))
                {
                    if (int.TryParse(stepTimeString, out int timeValue))
                    {
                        // Assume input is in seconds by default
                        if (timeValue < 60)
                        {
                            stepTime = TimeSpan.FromSeconds(timeValue);
                        }
                        else
                        {
                            // For larger numbers, treat as minutes
                            stepTime = TimeSpan.FromMinutes(timeValue);
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Invalid time input for step {stepTime}. Please enter a number representing seconds or minutes.");
                        continue;
                    }
                }
                


                var cookingStep = new CookingStep(StepInfo, StepNumber, stepTime);

                cookingStepList.Add(cookingStep);





            }
            return cookingStepList;


        }
        private Recipe createRecipe(ObjectId userId)
        {
            List<Ingredient> ingredientsList = ReadDataIntoIngredient();
            List<CookingStep> cookingStepsList = ReadDataIntoCookingSteps();
            string recipeName = recipeTitlebox.Text;
            int servings = Int32.Parse(recipeServingsTextbox.Text);


            return new Recipe(userId)
            {
                UserId = userId,
                Servings = servings,

                Name = recipeName,
                IngredientsList = ingredientsList,
                CookingStepsList = cookingStepsList
            };

            

        }

        private async void button1_Click(object sender, EventArgs e) //Recipe Creation Event
        {
            ObjectId currentUserId = Useraccount.UserId;
            Recipe recipe = createRecipe(currentUserId);
            SaveRecipeToBson(recipe);
            await SaveRecipeToMongoDB(recipe);

            this.Close();



        }
        private void SaveRecipeToBson(Recipe recipe) //Desktop Save
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"{recipe.Name}.bson");
            byte[] bsonData = recipe.ToBson();
            File.WriteAllBytes(path, bsonData);
            MessageBox.Show($"Recipe saved to {path} as a BSON file.");
        }
        private async Task SaveRecipeToMongoDB(Recipe recipe) //Backup to MongoDatabase
        {

            string connectionString = "mongodb+srv://scederdahl12:fireHouse123456@cluster0.omeqq.mongodb.net/?appName=Cluster0";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("RecipeCalculatorAccounts");
            var collection = database.GetCollection<Recipe>("RecipeIndex");

            await collection.InsertOneAsync(recipe);

            MessageBox.Show("Recipe backed up to MongoDB successfully!");
        }

        private void recipeCreation_Load(object sender, EventArgs e)
        {

        }
    }
}





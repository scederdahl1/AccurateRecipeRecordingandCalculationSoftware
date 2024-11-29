using MongoDB.Bson;
using MongoDB.Bson.IO;
using MongoDB.Bson.Serialization;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MongoDB.Driver;
using System.Threading.Tasks;

namespace AccurateRecipeRecordingandCalculationSoftware
{
    public partial class dishCreationForm : Form
    {
        public dishCreationForm()
        {
            InitializeComponent();
        }

        private void loadRecipeFilesIntoCheckbox(string directoryPath, ObjectId currentUserId)
        {
            try
            {
                var files = Directory.GetFiles(directoryPath, "*.bson");
                recipeFileCheckbox.Items.Clear();

                foreach (var file in files)
                {
                    try
                    {
                        byte[] bsonData = File.ReadAllBytes(file);
                        var recipeDocument = BsonSerializer.Deserialize<BsonDocument>(bsonData);

                        if (recipeDocument.Contains("UserId") && recipeDocument["UserId"] == currentUserId && recipeDocument.Contains("fileType") && recipeDocument["fileType"] == "recipe")
                        {
                            recipeFileCheckbox.Items.Add(Path.GetFileName(file));
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle any file that fails to deserialize
                        MessageBox.Show($"Error processing file {file}: {ex.Message}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load files: {ex.Message}");
            }
        }

        private void dishCreationForm_Load(object sender, EventArgs e)
        {
            ObjectId currentUserId = Useraccount.UserId; 
            string directoryPath = "C:\\Users\\PC\\Desktop";

            loadRecipeFilesIntoCheckbox(directoryPath, currentUserId);
        }

        private async void createDishBtn_Click(object sender, EventArgs e)
        {
            if (recipeFileCheckbox.CheckedItems.Count == 0)
            {
                MessageBox.Show("No files selected. Please check at least one file.");
                return;
            }
            ObjectId userId = Useraccount.UserId;

            string dishName = dishNameTxtBox.Text;
            Dish myDish = new Dish(dishName, userId);

            foreach (string fileName in recipeFileCheckbox.CheckedItems)
            {
                try
                {
                    // Reconstruct the full file path
                    string directoryPath = "C:\\Users\\PC\\Desktop";
                    string filePath = Path.Combine(directoryPath, fileName);

                    // Read and process the BSON file
                    byte[] bsonData = File.ReadAllBytes(filePath);
                    var recipeDocument = BsonSerializer.Deserialize<BsonDocument>(bsonData);

                    // Deserialize BSON data into Recipe object
                    Recipe recipe = BsonSerializer.Deserialize<Recipe>(bsonData);
                    myDish.Recipes.Add(recipe);

                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error processing file {fileName}: {ex.Message}");
                }
            }

            // Combine and reorder cooking steps
            myDish.CombineCookingSteps();

            // Dish File Name verification
            string sanitizedDishName = string.Concat(myDish.Name.Split(Path.GetInvalidFileNameChars()));
            string bsonFilePath = Path.Combine("C:\\Users\\PC\\Desktop", sanitizedDishName + ".bson");

            // Serialize the Dish object to BSON
            using (var fileStream = File.Create(bsonFilePath))
            {
                // Create a BsonBinaryWriter to write to the file stream
                using (var writer = new BsonBinaryWriter(fileStream))
                {
                    // Serialize the Dish object to the BSON format
                    BsonSerializer.Serialize(writer, myDish);
                }
            }

            
            MessageBox.Show($"Dish saved to {bsonFilePath}");

            await SaveDishToMongoDB(myDish);


        }
        private async Task SaveDishToMongoDB(Dish myDish) //Backup to MongoDatabase
        {

            string connectionString = "mongodb+srv://scederdahl12:fireHouse123456@cluster0.omeqq.mongodb.net/?appName=Cluster0";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("RecipeCalculatorAccounts");
            var collection = database.GetCollection<Dish>("DishIndex");

            await collection.InsertOneAsync(myDish);

            MessageBox.Show("Dish backed up to MongoDB successfully!");
        }

    }
}

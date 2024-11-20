using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccurateRecipeRecordingandCalculationSoftware
{
    internal class Dish
    {
        public ObjectId UserId { get; set; }
        public string Name { get; set; }
        public List<Recipe> Recipes { get; set; }
        public List<CookingStep> CombinedCookingSteps { get; set; }
        public string fileType { get; set; }

        public Dish(string name, ObjectId userId)
        {

            Name = name;
            Recipes = new List<Recipe>();
            CombinedCookingSteps = new List<CookingStep>();
            fileType = "Dish";
            UserId = userId;


        }
        public void AddRecipe(Recipe recipe)
        {
            Recipes.Add(recipe);
            CombineCookingSteps();
        }
        public void CombineCookingSteps()
        {
            CombinedCookingSteps = Recipes
                .SelectMany(r => r.CookingStepsList)
                .OrderBy(step => step.StepTime)
                .ToList();


            for (int i = 0; i < CombinedCookingSteps.Count; i++)
            {
                CombinedCookingSteps[i].StepNumber = i + 1;
            }

        }




    }
}


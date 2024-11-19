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
        public string Name { get; set; }    
        public List<Recipe> Recipes { get; set; }
        public List<CookingStep> CombinedCookingSteps { get;  set; }

        public Dish(string name)
        {
            Name = name;
            Recipes = new List<Recipe>();
            CombinedCookingSteps = new List<CookingStep>();

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

        
        for (int i = 0; i<CombinedCookingSteps.Count; i++)
            {
                CombinedCookingSteps[i].StepNumber = i + 1;
            }
          
}

        

    }
}


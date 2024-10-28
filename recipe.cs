using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccurateRecipeRecordingandCalculationSoftware;


namespace AccurateRecipeRecordingandCalculationSoftware
{
    internal class recipe
    {
        public string Name { get; set; }
        public List<Ingredient> IngredientsList { get; set; }   
        public List<CookingStep> cookingStepsList { get; set; }
        public string prepTime {  get; set; }
        public string cookTime {  get; set; }
        public int servings {  get; set; }
        public double costPerServing { get; set; };

        public recipe (string name)
        {
            Name = name;
            IngredientsList = new List<Ingredient>();
            cookingStepsList = new List<CookingStep>();
            servings = 0;
            costPerServing = 0;
            cookTime = cookTime;
            servings = 0;
        }
        public void addIngredient(Ingredient ingredient)
        {
            IngredientsList.Add(ingredient);
                
        }
        public void removeIngredient(string ingredientName)
        {
            var ingredientToRemove = IngredientsList.Find(i => i.name.Equals(ingredientName, StringComparison.OrdinalIgnoreCase));
            if(ingredientToRemove != null)
            {
                IngredientsList.Remove(ingredientToRemove);
            }
        }
        
        public void addCookingStep(CookingStep cookingStep)
        {
            cookingStepsList.Add(cookingStep);
        }
       
    }
}

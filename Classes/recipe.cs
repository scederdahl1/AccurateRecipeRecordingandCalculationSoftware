using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace AccurateRecipeRecordingandCalculationSoftware
{
    public class Recipe
    {
       
        public ObjectId Id { get; set; }
        public ObjectId UserId { get; set; }
        public string Name { get; set; }
        public List<Ingredient> IngredientsList { get; set; }
        public List<CookingStep> CookingStepsList { get; set; }
        public TimeSpan PrepTime { get; set; }
        public TimeSpan CookTime { get; set; }
        public int Servings { get; set; }
        public double CostPerServing { get; set; }
        public string fileType { get; set; }
        

        public Recipe() // Default constructor
        {
            IngredientsList = new List<Ingredient>();
            CookingStepsList = new List<CookingStep>();
            CostPerServing = 0;
            PrepTime = TimeSpan.Zero;
            CookTime = TimeSpan.Zero;
            Servings = 0;
            fileType = "recipe";
        }

        public Recipe(ObjectId userId) : this() // Constructor with user ID
        {
            UserId = userId; // Set the UserId when creating the object
        }
    }
}
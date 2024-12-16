using AccurateRecipeRecordingandCalculationSoftware.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MongoDB.Driver.WriteConcern;

namespace AccurateRecipeRecordingandCalculationSoftware
{
    public partial class recipeView : Form
    {
        private Recipe _recipe;
        public recipeView(Recipe recipe)
        {
            InitializeComponent();
            _recipe = recipe;
            DisplayRecipe();

        }
        private void DisplayRecipe()
        {
            ingdgview.DataSource = _recipe.IngredientsList;
            ingdgview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            ingdgview.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


            viewedRecipeStepsDG.DataSource = _recipe.CookingStepsList;
            viewedRecipeStepsDG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            viewedRecipeStepsDG.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            recipeViewNamelbl.Text = _recipe.Name;

            CalculateTotals();



        }
        private void CalculateTotals()
        {
            decimal totalCost = 0;
            decimal costPerServing = 0;

            foreach (DataGridViewRow row in ingdgview.Rows)
            {
                if (row.Cells["Cost"].Value != null
                    && decimal.TryParse(row.Cells["Cost"].Value.ToString(), out decimal ingredientCost))
                {
                    totalCost += ingredientCost;
                }
            }
            if (_recipe.Servings > 0)
            {
                costPerServing = totalCost / _recipe.Servings;
            }
            recipeTotalCostxtbx.Text = totalCost.ToString("C");
            costPerServingTxtbox.Text = costPerServing > 0 ? costPerServing.ToString("C") : "N/A";
        }
    }
}

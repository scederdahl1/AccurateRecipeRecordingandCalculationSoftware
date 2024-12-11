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
            viewedRecipeStepsDG.AutoSizeRowsMode= DataGridViewAutoSizeRowsMode.AllCells;

            recipeViewNamelbl.Text = _recipe.Name;



        }
    }
}

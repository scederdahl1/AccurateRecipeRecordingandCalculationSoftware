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

namespace AccurateRecipeRecordingandCalculationSoftware
{
    public partial class DishView : Form
    {
        private Dish _dish;
        public DishView(Dish dish)
        {
            InitializeComponent();
            _dish = dish;
            DisplayDish();
        }

        private void DisplayDish()
        {
            dishNamelbl.Text = _dish.Name;  

            foreach(var recipe in _dish.Recipes)
            {
                TabPage tabPage = new TabPage(recipe.Name);

                DataGridView ingredientsDataGridView = new DataGridView
                {
                    DataSource = recipe.IngredientsList,
                    Dock = DockStyle.Top,
                    BackgroundColor = Color.White,
                    AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells,
                    AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                };
                tabPage.Controls.Add(ingredientsDataGridView);

                tabControl1.TabPages.Add(tabPage);
            }
            combinedStepsView.DataSource = _dish.CombinedCookingSteps;
            combinedStepsView.AutoResizeColumns();
            combinedStepsView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;



        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccurateRecipeRecordingandCalculationSoftware;
using MongoDB.Bson;
using MongoDB.Driver;


namespace AccurateRecipeRecordingandCalculationSoftware
{
    public partial class AccurateRecipeRecordingandCalculationSoftware : Form
    {
        
        public AccurateRecipeRecordingandCalculationSoftware()
        {
            InitializeComponent();

        }

        private void AccurateRecipeRecordingandCalculationSoftware_Load(object sender, EventArgs e)
        {
            
        }

        private void recipeCreationLabell_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            recipeCreation createdRecipe = new recipeCreation();
            createdRecipe.Show();
            
        }
    }
}

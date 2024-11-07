using MongoDB.Bson;
using MongoDB.Bson.IO;
using MongoDB.Bson.Serialization;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace AccurateRecipeRecordingandCalculationSoftware
{
    public partial class dishCreationForm : Form
    {
        public dishCreationForm()
        {
            InitializeComponent();
        }

        private void loadRecipeFilesIntoCheckbox(string directoryPath)
        {
            try
            {
                var files = Directory.GetFiles(directoryPath)
                    .Where(File => File.EndsWith(".bson"))
                    .Select(Path.GetFileName)
                    .ToArray();
                recipeFileCheckbox.Items.Clear();
                foreach (var file in files)
                {
                    recipeFileCheckbox.Items.Add(file);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dishCreationForm_Load(object sender, EventArgs e)
        {
            string directoryPath = "C:\\Users\\PC\\Desktop";

            loadRecipeFilesIntoCheckbox(directoryPath);
        }
    }
}
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
using MongoDB.Bson.Serialization.Serializers;
using System.IO;
using MongoDB.Bson.Serialization;



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
            ObjectId currentUserId = Useraccount.UserId;
            string directoryPath = "C:\\Users\\PC\\Desktop";
            LoadListBoxes(directoryPath, currentUserId);




        }

        private void recipeCreationLabell_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            recipeCreation createdRecipe = new recipeCreation();
            createdRecipe.Show();

        }

        private void createDishLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dishCreationForm createdDishForm = new dishCreationForm();
            createdDishForm.Show();
        }

        private void LoadListBoxes(string directoryPath, ObjectId currentUserId)
        {
            try
            {
                // Get all BSON files in the specified directory
                var files = Directory.GetFiles(directoryPath, "*.bson");

                // Reset and hide UI elements
                existingRecipeslbl.Visible = false;
                recipeListBox1.Visible = false;
                existingDishlbl.Visible = false;
                dishFileListBox.Visible = false;
                createDishLabel.Visible = false;
                recipeCreationLabell.Visible = false;


                recipeListBox1.Items.Clear();
                dishFileListBox.Items.Clear();

                foreach (var file in files)
                {
                    try
                    {
                        // Read and deserialize BSON file
                        byte[] bsonData = File.ReadAllBytes(file);
                        var recipeDocument = BsonSerializer.Deserialize<BsonDocument>(bsonData);

                        // Check for the required fields
                        if (recipeDocument.Contains("UserId") && recipeDocument["UserId"] == currentUserId &&
                            recipeDocument.Contains("fileType"))
                        {
                            string fileType = recipeDocument["fileType"].AsString;

                            if (fileType == "recipe")
                            {
                                recipeListBox1.Items.Add(Path.GetFileName(file));
                                recipeListBox1.Visible = true;
                                existingRecipeslbl.Visible = true;
                                recipeCreationLabell.Visible = true;

                            }
                            else if (fileType == "Dish")
                            {
                                dishFileListBox.Items.Add(Path.GetFileName(file));
                                dishFileListBox.Visible = true;
                                existingDishlbl.Visible = true;
                                createDishLabel.Visible = true;

                            }


                        }
                    }
                    catch (Exception ex)
                    {
                        // Provide context for individual file errors
                        MessageBox.Show($"Error processing file '{file}': {ex.Message}", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (!recipeListBox1.Visible && !dishFileListBox.Visible)
                {
                    createDishLabel.Visible = true;
                    recipeCreationLabell.Visible = true;

                }
            }
            catch (Exception ex)
            {
                // General error handling
                MessageBox.Show($"An error occurred while accessing files: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void recipeListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void newCookingSessionlnklbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TestcookingSessionEntryForm newSession = new TestcookingSessionEntryForm();
            newSession.Show();
        }
    }
}
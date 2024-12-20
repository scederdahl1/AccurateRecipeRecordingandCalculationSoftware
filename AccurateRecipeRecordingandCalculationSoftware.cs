﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using System;
using System.IO;
using System.Windows.Forms;
using AccurateRecipeRecordingandCalculationSoftware.Properties;
using AccurateRecipeRecordingandCalculationSoftware.Classes;
using AccurateRecipeRecordingandCalculationSoftware;



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


            createdRecipe.RecipeCreated += (s, args) =>
            {
                string directorypath = "C:\\Users\\PC\\Desktop";
                ObjectId currentUserId = Useraccount.UserId;
                LoadListBoxes(directorypath, currentUserId);
            };

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
                sessionListbox.Visible = false;


                recipeListBox1.Items.Clear();
                dishFileListBox.Items.Clear();
                sessionListbox.Items.Clear();
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
                if (recipeListBox1.Visible && !dishFileListBox.Visible)
                {
                    createDishLabel.Visible = true;
                    existingDishlbl.Visible = true;


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
            if (recipeListBox1.SelectedItem != null)
            {
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string selectedFileName = recipeListBox1.SelectedItem.ToString();
                string selectedFilePath = Path.Combine(desktopPath, selectedFileName);
                try
                {
                    Recipe loadedRecipe = LoadRecipeFromBson(selectedFilePath);

                    recipeView recipeView = new recipeView(loadedRecipe);
                    recipeView.Text = loadedRecipe.Name;
                    recipeView.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading recipe: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private Recipe LoadRecipeFromBson(string filePath)
        {
            try
            {
                byte[] bsonData = File.ReadAllBytes(filePath);
                using (var memoryStream = new MemoryStream(bsonData))
                {
                    return BsonSerializer.Deserialize<Recipe>(memoryStream);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load recipe from BSON file. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


        private void newCookingSessionlnklbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TestcookingSessionEntryForm newSession = new TestcookingSessionEntryForm();
            newSession.Show();
        }

        private void dishFileListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dishFileListBox.SelectedItem != null)
            {
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string selectedFileName = dishFileListBox.SelectedItem.ToString();
                string selectedFilePath = Path.Combine(desktopPath, selectedFileName);
                try
                {
                    Dish loadedDish = LoadDishFromBson(selectedFilePath);

                    DishView dishView = new DishView(loadedDish);
                    dishView.Text = loadedDish.Name;
                    dishView.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading recipe: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private Dish LoadDishFromBson(string filePath)
        {
            try
            {
                byte[] bsonData = File.ReadAllBytes(filePath);
                using (var memoryStream = new MemoryStream(bsonData))
                {
                    return BsonSerializer.Deserialize<Dish>(memoryStream);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load recipe from BSON file. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

    }
}
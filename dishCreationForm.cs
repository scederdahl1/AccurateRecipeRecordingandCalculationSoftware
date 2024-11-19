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

        private void loadRecipeFilesIntoCheckbox(string directoryPath, ObjectId currentUserId)
        {
            try
            {
                var files = Directory.GetFiles(directoryPath, "*.bson");
                recipeFileCheckbox.Items.Clear();

                foreach (var file in files)
                {
                    try
                    {
                        
                        byte[] bsonData = File.ReadAllBytes(file);
                        var recipeDocument = BsonSerializer.Deserialize<BsonDocument>(bsonData);

                        
                        if (recipeDocument.Contains("UserId") && recipeDocument["UserId"] == currentUserId && recipeDocument.Contains("fileType") && recipeDocument["fileType"] == "recipe")
                        {
                            recipeFileCheckbox.Items.Add(Path.GetFileName(file));
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle any file that fails to deserialize 
                        MessageBox.Show($"Error processing file {file}: {ex.Message}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load files: {ex.Message}");
            }
        }

        private void dishCreationForm_Load(object sender, EventArgs e)
        {
            ObjectId currentUserId = Useraccount.UserId; // Replace with actual logged-in user's ID
            string directoryPath = "C:\\Users\\PC\\Desktop";

            loadRecipeFilesIntoCheckbox(directoryPath, currentUserId);
        }

        private void createDishBtn_Click(object sender, EventArgs e)
        {
            if (recipeFileCheckbox.CheckedItems.Count == 0)
            {
                MessageBox.Show("No files selected. Please check at least one file.");
                return;
            }
            foreach (string fileName in recipeFileCheckbox.CheckedItems)
            {
                try
                {
                    // Reconstruct the full file path
                    string directoryPath = "C:\\Users\\PC\\Desktop"; 
                    string filePath = Path.Combine(directoryPath, fileName);

                    // Read and process the BSON file
                    byte[] bsonData = File.ReadAllBytes(filePath);
                    var recipeDocument = BsonSerializer.Deserialize<BsonDocument>(bsonData);

                    // Example: Display recipe name
                    if (recipeDocument.Contains("Name"))
                    {
                        string recipeName = recipeDocument["Name"].ToString();
                        MessageBox.Show($"Processing recipe: {recipeName}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error processing file {fileName}: {ex.Message}");
                }
            }
        }

    }
    }
}
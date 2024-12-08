using AccurateRecipeRecordingandCalculationSoftware.Classes;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace AccurateRecipeRecordingandCalculationSoftware
{
    public partial class TestcookingSessionEntryForm : Form
    {
        private List<ObjectId> linkedFilesIds = new List<ObjectId>();

        public TestcookingSessionEntryForm()
        {
            InitializeComponent();
        }

        private void selectAssociateFileslbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ObjectId currentUserId = Useraccount.UserId;
            SelectUserSpecificBsonFiles(currentUserId);
        }


        public void SelectUserSpecificBsonFiles(ObjectId currentUserId)
        {
            string directoryPath = "C:\\Users\\PC\\Desktop";
            var validFilePaths = new List<string>();


            var bsonFiles = Directory.GetFiles(directoryPath, "*.bson");


            foreach (var file in bsonFiles)
            {
                try
                {
                    byte[] bsonData = File.ReadAllBytes(file);
                    var recipeDocument = BsonSerializer.Deserialize<BsonDocument>(bsonData);


                    if (recipeDocument.Contains("UserId") && recipeDocument["UserId"] == currentUserId)
                    {

                        validFilePaths.Add(file);
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine($"Error reading file '{file}': {ex.Message}");
                }
            }


            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "BSON Files (*.bson)|*.bson";
                openFileDialog.Multiselect = true;
                openFileDialog.InitialDirectory = directoryPath;

                openFileDialog.FileOk += (sender, e) =>
                {
                    var selectedFiles = openFileDialog.FileNames;
                    foreach (var file in selectedFiles)
                    {
                        // Check if the selected file is not in the valid file paths list
                        if (!validFilePaths.Contains(file))
                        {
                            MessageBox.Show($"File '{file}' is not associated with the current user.");
                            e.Cancel = true;  // Cancel the dialog if the file doesn't match the user
                            break;
                        }
                    }
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Process the selected files that are valid
                    linkedFilesIds = openFileDialog.FileNames
                        .Where(file => validFilePaths.Contains(file))
                        .Select(file =>
                        {
                            byte[] bsonData = File.ReadAllBytes(file);
                            var recipeDocument = BsonSerializer.Deserialize<BsonDocument>(bsonData);
                            return recipeDocument["_id"].AsObjectId;
                        })
                        .ToList();

                    // For debugging
                    Console.WriteLine("Linked File IDs:");
                    foreach (var fileId in linkedFilesIds)
                    {
                        Console.WriteLine(fileId);
                    }
                }
            }
        }




        private void SaveTestCookingSession(TestCookingSession session)
        {

            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"session1.bson");
            byte[] bsonData = session.ToBson();
            File.WriteAllBytes(path, bsonData);
            MessageBox.Show($"Session saved to {path} as a BSON file.");
        }




        private void sessionSaveBtn_Click(object sender, EventArgs e)
        {
            var currentUserId = Useraccount.UserId;
            DateTime sessionDate = testCookingSessionDTP.Value;
            var sessionRecap = new List<String> { "Test recap" };


            var session = new TestCookingSession(currentUserId, sessionDate, sessionRecap)
            {
                AssociatedFilesId = linkedFilesIds
            };

            // Save the session data to BSON (or MongoDB)
            SaveTestCookingSession(session);

            MessageBox.Show("Session data saved.");
        }
    }
}



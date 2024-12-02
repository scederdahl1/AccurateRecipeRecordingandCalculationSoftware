using System;
using System.Collections.Generic;
using MongoDB.Bson;

namespace AccurateRecipeRecordingandCalculationSoftware
{
    internal class TestCookingSession
    {
        public DateTime SessionDate { get; set; } 
        public ObjectId UserId { get; set; } 
        public List<ObjectId> AssociatedFilesId { get; set; } 
        public List<string> SessionRecap { get; set; }

   
        public TestCookingSession(ObjectId userId, DateTime sessionDate, List<string> bsonFilePaths)
        {
            SessionDate = sessionDate.Date; 
            UserId = userId;
            AssociatedFilesId = ConvertFilePathsToObjectIds(bsonFilePaths); 
            SessionRecap = new List<string>(); 
        }

   
        private List<ObjectId> ConvertFilePathsToObjectIds(List<string> filePaths)
        {
            var objectIds = new List<ObjectId>();

            foreach (var filePath in filePaths)
            {
                try
                {
                    
                    var bsonData = System.IO.File.ReadAllBytes(filePath);
                    var document = BsonDocument.Parse(System.Text.Encoding.UTF8.GetString(bsonData));

                    if (document.TryGetValue("_id", out BsonValue idValue) && idValue.IsObjectId)
                    {
                        objectIds.Add(idValue.AsObjectId);
                    }
                    else
                    {
                        throw new Exception($"File '{filePath}' does not contain a valid ObjectId.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error reading file '{filePath}': {ex.Message}");
                }
            }

            return objectIds;
        }

        public void AddRecap(string recapEntry)
        {
            if (!string.IsNullOrWhiteSpace(recapEntry))
            {
                SessionRecap.Add(recapEntry);
            }
        }
    }
}
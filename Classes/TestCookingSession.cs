using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Attributes;

namespace AccurateRecipeRecordingandCalculationSoftware
{
    internal class TestCookingSession

    {

        public DateTime SessionDate { get; set; }
        public ObjectId UserId { get; set; }

        public List<ObjectId> AssociatedFilesId { get; set; }

        public string[] SessionRecap {  get; set; }

        public TestCookingSession(ObjectId userId, DateTime sessionDate, List<String> associateFilesIDs) {
            SessionDate = DateSet(sessionDate);
            UserId = userId;
            AssociatedFilesId = FileIdReader(associateFilesIDs);

            
            


        
        }
        public DateTime DateSet (DateTime sessionDate)
        {
            sessionDate = sessionDate.Date;
            return sessionDate;
        }

        public static List<ObjectId> FileIdReader(List<String> AssociateFileIDs)
        {
            var result = new List<ObjectId>();

            try
            {
               foreach()
                {
                   
                }

            }

        }



    }
}

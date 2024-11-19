using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AccurateRecipeRecordingandCalculationSoftware
{
    internal class Useraccount
    {
        public string email {  get; set; }
        public string password { get; set; }
        public static ObjectId UserId { get; set; }

    }
}

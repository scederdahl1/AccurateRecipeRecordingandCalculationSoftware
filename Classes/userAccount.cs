using MongoDB.Bson;


namespace AccurateRecipeRecordingandCalculationSoftware.Classes
{
    internal class Useraccount
    {
        public string email { get; set; }
        public string password { get; set; }
        public static ObjectId UserId { get; set; }

    }
}

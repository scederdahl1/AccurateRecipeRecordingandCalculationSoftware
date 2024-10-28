using System;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Drawing;
using System.Drawing.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using AccurateRecipeRecordingandCalculationSoftware;

namespace AccurateRecipeRecordingandCalculationSoftware
{
    public partial class userRegistration : Form
    {
        
        public userRegistration()
        {
            InitializeComponent();
        }

        private async void registerButton_Click(object sender, EventArgs e)
        {
            string userRegisterEmail = registEmailbox.Text;
            string userRegisterPass = registPassBox.Text;

            bool userExists = await UserExistsCheck(userRegisterEmail);

            if( userExists == true)
            {
                accountExistsLabel.Visible = true;
            }
            else
            if(userExists == false)
            {
                await registerUser(userRegisterEmail, userRegisterPass);
                this.Close();
               
            }
            
        }

        private async Task<Boolean> UserExistsCheck(string userRegisterEmail)
        {
         
               String connectionUri = "mongodb+srv://scederdahl12:fireHouse123456@cluster0.omeqq.mongodb.net/?appName=Cluster0";
                MongoClient dbClient = new MongoClient(connectionUri);
                var database = dbClient.GetDatabase("RecipeCalculatorAccounts");
                var collection = database.GetCollection<BsonDocument>("userIndex");
                var filter = Builders<BsonDocument>.Filter.And(
                Builders<BsonDocument>.Filter.Eq("email", userRegisterEmail)
    
        );

                var existingUser = await collection.Find(filter).FirstOrDefaultAsync();

                if (existingUser != null)
                {

                    return true;
                }

                return false;
            }
        private async Task registerUser(string userRegisterEmail, string userRegisterPass)
        {

            String connectionUri = "mongodb+srv://scederdahl12:fireHouse123456@cluster0.omeqq.mongodb.net/?appName=Cluster0";
            MongoClient dbClient = new MongoClient(connectionUri);
            var database = dbClient.GetDatabase("RecipeCalculatorAccounts");
            var collection = database.GetCollection<Useraccount>("userIndex");

            var newAccount = new Useraccount { email = userRegisterEmail, password = userRegisterPass};
            await collection.InsertOneAsync(newAccount);

        }
        }
        
    }
    


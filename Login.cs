using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Threading;

namespace AccurateRecipeRecordingandCalculationSoftware
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string email = emailTextBox.Text;
            string password = passwordTextBox.Text;

            if (email.Contains("@") && email.Contains(".com") || email.Contains(".net"))
            {
                if (password.Length < 15)
                {
                    passwordLabel.Text = "invalid length";
                }
                Boolean userCheck = authenUser(email, password);
                if (userCheck == true)
                {
                    MessageBox.Show("User Exists");
                }
                else
                {
                    MessageBox.Show("User Does not exits!");
                }
                
            }

        }
         private Boolean authenUser(string username, string password)
        {
            String connectionUri = "mongodb+srv://scederdahl12:fireHouse123456@cluster0.omeqq.mongodb.net/?appName=Cluster0";
            MongoClient dbClient = new MongoClient(connectionUri);
            var database = dbClient.GetDatabase("RecipeCalculatorAccounts");
            var collection = database.GetCollection<BsonDocument>("UserIndexs");
            var filter = Builders<BsonDocument>.Filter.Eq(username, password );
            var existingUser = collection.Find(filter);
            if (existingUser != null)
            {
                return true;
            }
            return false;

            } 

              

        
    }
}

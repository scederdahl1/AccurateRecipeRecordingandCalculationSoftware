﻿using AccurateRecipeRecordingandCalculationSoftware.Classes;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace AccurateRecipeRecordingandCalculationSoftware
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            





        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool validCheck { get; set; }



        private async void LoginButton_Click(object sender, EventArgs e)
        {
            string username = emailTextBox.Text;
            string password = passwordTextBox.Text;

            try
            {
                bool userCheck = await authenUser(username, password);
                validCheck = userCheck;

                if (validCheck == true)
                {
                    this.DialogResult = DialogResult.OK; // Indicate a successful login

                    this.Close(); // Close the login form
                }
          
                else
                {

                    invalidInfoLabel.Visible = true;
                    passwordTextBox.Clear();



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private async Task<bool> authenUser(string username, string password) //User Account Validatiom
        {
            String connectionUri = "mongodb+srv://scederdahl12:fireHouse123456@cluster0.omeqq.mongodb.net/?appName=Cluster0";
            MongoClient dbClient = new MongoClient(connectionUri);
            var database = dbClient.GetDatabase("RecipeCalculatorAccounts");
            var collection = database.GetCollection<BsonDocument>("userIndex");
            var filter = Builders<BsonDocument>.Filter.And(
        Builders<BsonDocument>.Filter.Eq("email", username),
        Builders<BsonDocument>.Filter.Eq("password", password)
    );

            var existingUser = await collection.Find(filter).FirstOrDefaultAsync();

            if (existingUser != null)
            {
                Useraccount.UserId = existingUser["_id"].AsObjectId;

                return true;
            }

            return false;
        }

        private void RegistrationLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            userRegistration registration = new userRegistration();
            registration.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(emailTextBox.Text))
            {
                invalidInfoLabel.Visible = false;

            }

        }

        private void registrationLink_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            userRegistration registration = new userRegistration();
            registration.Show();
        }
        


    }
    }



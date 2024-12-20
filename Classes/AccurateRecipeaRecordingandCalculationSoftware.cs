﻿using System;
using System.Windows.Forms;


namespace AccurateRecipeRecordingandCalculationSoftware.Classes
{
    internal static class AccurateRecipeaRecordingandCalculationSoftware
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            bool isLoggedIn = false;

            while (!isLoggedIn)     //The Login loop
            {
                using (Login loginAttempt = new Login())
                {
                    if (loginAttempt.ShowDialog() == DialogResult.OK)
                    {
                        isLoggedIn = loginAttempt.validCheck; // Set isLoggedIn based on login validity

                        if (isLoggedIn)
                        {
                            // Proceed to the main form
                            Application.Run(new AccurateRecipeRecordingandCalculationSoftware());
                        }
                        else
                        {
                            MessageBox.Show("User doesn't exist. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }
    }
}
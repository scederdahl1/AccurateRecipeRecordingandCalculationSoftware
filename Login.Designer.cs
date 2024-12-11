
using AccurateRecipeRecordingandCalculationSoftware.Properties;
namespace AccurateRecipeRecordingandCalculationSoftware
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            emailLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            emailTextBox = new System.Windows.Forms.TextBox();
            passwordTextBox = new System.Windows.Forms.TextBox();
            LoginButton = new System.Windows.Forms.Button();
            registrationLink = new System.Windows.Forms.LinkLabel();
            invalidInfoLabel = new System.Windows.Forms.Label();
            loginLogoBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)loginLogoBox1).BeginInit();
            SuspendLayout();
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            emailLabel.Location = new System.Drawing.Point(119, 85);
            emailLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(94, 32);
            emailLabel.TabIndex = 0;
            emailLabel.Text = "Email:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            passwordLabel.Location = new System.Drawing.Point(72, 127);
            passwordLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(151, 33);
            passwordLabel.TabIndex = 1;
            passwordLabel.Text = "Password:";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new System.Drawing.Point(233, 84);
            emailTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            emailTextBox.MaxLength = 320;
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new System.Drawing.Size(164, 31);
            emailTextBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new System.Drawing.Point(233, 127);
            passwordTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            passwordTextBox.MaxLength = 15;
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new System.Drawing.Size(164, 31);
            passwordTextBox.TabIndex = 3;
            // 
            // LoginButton
            // 
            LoginButton.Location = new System.Drawing.Point(233, 242);
            LoginButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new System.Drawing.Size(125, 44);
            LoginButton.TabIndex = 4;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // registrationLink
            // 
            registrationLink.AutoSize = true;
            registrationLink.Location = new System.Drawing.Point(227, 177);
            registrationLink.Name = "registrationLink";
            registrationLink.Size = new System.Drawing.Size(170, 25);
            registrationLink.TabIndex = 5;
            registrationLink.TabStop = true;
            registrationLink.Text = "New ? Register Here";
            registrationLink.LinkClicked += registrationLink_LinkClicked_1;
            // 
            // invalidInfoLabel
            // 
            invalidInfoLabel.AutoSize = true;
            invalidInfoLabel.Location = new System.Drawing.Point(207, 53);
            invalidInfoLabel.Name = "invalidInfoLabel";
            invalidInfoLabel.Size = new System.Drawing.Size(215, 25);
            invalidInfoLabel.TabIndex = 6;
            invalidInfoLabel.Text = "Invalid Email or password";
            invalidInfoLabel.Visible = false;
            // 
            // loginLogoBox1
            // 
            loginLogoBox1.Image = Resources.logo;
            loginLogoBox1.Location = new System.Drawing.Point(444, 16);
            loginLogoBox1.Name = "loginLogoBox1";
            loginLogoBox1.Size = new System.Drawing.Size(184, 186);
            loginLogoBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            loginLogoBox1.TabIndex = 7;
            loginLogoBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Control;
            ClientSize = new System.Drawing.Size(640, 310);
            Controls.Add(loginLogoBox1);
            Controls.Add(invalidInfoLabel);
            Controls.Add(registrationLink);
            Controls.Add(LoginButton);
            Controls.Add(passwordTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(emailLabel);
            Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            Name = "Login";
            Text = "CulinaCalc";
            
            ((System.ComponentModel.ISupportInitialize)loginLogoBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.LinkLabel registrationLink;
        private System.Windows.Forms.Label invalidInfoLabel;
        private System.Windows.Forms.PictureBox loginLogoBox1;
    }
}
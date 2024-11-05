namespace AccurateRecipeRecordingandCalculationSoftware
{
    partial class userRegistration
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
            this.emailRegisterlbl = new System.Windows.Forms.Label();
            this.registPasswordLbl = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.registPassBox = new System.Windows.Forms.TextBox();
            this.registEmailbox = new System.Windows.Forms.TextBox();
            this.accountExistsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // emailRegisterlbl
            // 
            this.emailRegisterlbl.AutoSize = true;
            this.emailRegisterlbl.Location = new System.Drawing.Point(185, 72);
            this.emailRegisterlbl.Name = "emailRegisterlbl";
            this.emailRegisterlbl.Size = new System.Drawing.Size(52, 20);
            this.emailRegisterlbl.TabIndex = 0;
            this.emailRegisterlbl.Text = "Email:";
            // 
            // registPasswordLbl
            // 
            this.registPasswordLbl.AutoSize = true;
            this.registPasswordLbl.Location = new System.Drawing.Point(185, 113);
            this.registPasswordLbl.Name = "registPasswordLbl";
            this.registPasswordLbl.Size = new System.Drawing.Size(82, 20);
            this.registPasswordLbl.TabIndex = 1;
            this.registPasswordLbl.Text = "Password:";
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(221, 158);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(96, 35);
            this.registerButton.TabIndex = 3;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // registPassBox
            // 
            this.registPassBox.Location = new System.Drawing.Point(274, 110);
            this.registPassBox.MaxLength = 15;
            this.registPassBox.Name = "registPassBox";
            this.registPassBox.Size = new System.Drawing.Size(100, 26);
            this.registPassBox.TabIndex = 4;
            // 
            // registEmailbox
            // 
            this.registEmailbox.Location = new System.Drawing.Point(274, 69);
            this.registEmailbox.Name = "registEmailbox";
            this.registEmailbox.Size = new System.Drawing.Size(100, 26);
            this.registEmailbox.TabIndex = 5;
            // 
            // accountExistsLabel
            // 
            this.accountExistsLabel.AutoSize = true;
            this.accountExistsLabel.Location = new System.Drawing.Point(149, 23);
            this.accountExistsLabel.Name = "accountExistsLabel";
            this.accountExistsLabel.Size = new System.Drawing.Size(274, 20);
            this.accountExistsLabel.TabIndex = 7;
            this.accountExistsLabel.Text = "Account with that Email already exists";
            this.accountExistsLabel.Visible = false;
            // 
            // userRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 209);
            this.Controls.Add(this.accountExistsLabel);
            this.Controls.Add(this.registEmailbox);
            this.Controls.Add(this.registPassBox);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.registPasswordLbl);
            this.Controls.Add(this.emailRegisterlbl);
            this.Name = "userRegistration";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label emailRegisterlbl;
        private System.Windows.Forms.Label registPasswordLbl;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.TextBox registPassBox;
        private System.Windows.Forms.TextBox registEmailbox;
        private System.Windows.Forms.Label accountExistsLabel;
    }
}
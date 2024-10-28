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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.registPassBox = new System.Windows.Forms.TextBox();
            this.registEmailbox = new System.Windows.Forms.TextBox();
            this.retypedPassbox = new System.Windows.Forms.TextBox();
            this.accountExistsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Re-enter Password:";
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(274, 224);
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
            // retypedPassbox
            // 
            this.retypedPassbox.Location = new System.Drawing.Point(274, 150);
            this.retypedPassbox.MaxLength = 15;
            this.retypedPassbox.Name = "retypedPassbox";
            this.retypedPassbox.Size = new System.Drawing.Size(100, 26);
            this.retypedPassbox.TabIndex = 6;
            // 
            // accountExistsLabel
            // 
            this.accountExistsLabel.AutoSize = true;
            this.accountExistsLabel.Location = new System.Drawing.Point(185, 29);
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
            this.ClientSize = new System.Drawing.Size(554, 276);
            this.Controls.Add(this.accountExistsLabel);
            this.Controls.Add(this.retypedPassbox);
            this.Controls.Add(this.registEmailbox);
            this.Controls.Add(this.registPassBox);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "userRegistration";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.TextBox registPassBox;
        private System.Windows.Forms.TextBox registEmailbox;
        private System.Windows.Forms.TextBox retypedPassbox;
        private System.Windows.Forms.Label accountExistsLabel;
    }
}
namespace AccurateRecipeRecordingandCalculationSoftware
{
    partial class dishCreationForm
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
            this.openRecipeDialog = new System.Windows.Forms.OpenFileDialog();
            this.recipeFileCheckbox = new System.Windows.Forms.CheckedListBox();
            this.recipeSelectionLbl = new System.Windows.Forms.Label();
            this.dishNamelbl = new System.Windows.Forms.Label();
            this.dishNameTxtBox = new System.Windows.Forms.TextBox();
            this.createDishBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openRecipeDialog
            // 
            this.openRecipeDialog.Multiselect = true;
            // 
            // recipeFileCheckbox
            // 
            this.recipeFileCheckbox.FormattingEnabled = true;
            this.recipeFileCheckbox.Location = new System.Drawing.Point(44, 159);
            this.recipeFileCheckbox.Name = "recipeFileCheckbox";
            this.recipeFileCheckbox.Size = new System.Drawing.Size(182, 124);
            this.recipeFileCheckbox.TabIndex = 0;
            // 
            // recipeSelectionLbl
            // 
            this.recipeSelectionLbl.AutoSize = true;
            this.recipeSelectionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recipeSelectionLbl.Location = new System.Drawing.Point(24, 120);
            this.recipeSelectionLbl.Name = "recipeSelectionLbl";
            this.recipeSelectionLbl.Size = new System.Drawing.Size(219, 25);
            this.recipeSelectionLbl.TabIndex = 1;
            this.recipeSelectionLbl.Text = "Select Your recipes\r\n";
            // 
            // dishNamelbl
            // 
            this.dishNamelbl.AutoSize = true;
            this.dishNamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dishNamelbl.Location = new System.Drawing.Point(12, 35);
            this.dishNamelbl.Name = "dishNamelbl";
            this.dishNamelbl.Size = new System.Drawing.Size(108, 24);
            this.dishNamelbl.TabIndex = 2;
            this.dishNamelbl.Text = "Dish Name:";
            // 
            // dishNameTxtBox
            // 
            this.dishNameTxtBox.Location = new System.Drawing.Point(126, 40);
            this.dishNameTxtBox.Name = "dishNameTxtBox";
            this.dishNameTxtBox.Size = new System.Drawing.Size(100, 20);
            this.dishNameTxtBox.TabIndex = 3;
            // 
            // createDishBtn
            // 
            this.createDishBtn.Location = new System.Drawing.Point(84, 331);
            this.createDishBtn.Name = "createDishBtn";
            this.createDishBtn.Size = new System.Drawing.Size(75, 23);
            this.createDishBtn.TabIndex = 4;
            this.createDishBtn.Text = "Create Dish";
            this.createDishBtn.UseVisualStyleBackColor = true;
            this.createDishBtn.Click += new System.EventHandler(this.createDishBtn_Click);
            // 
            // dishCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 450);
            this.Controls.Add(this.createDishBtn);
            this.Controls.Add(this.dishNameTxtBox);
            this.Controls.Add(this.dishNamelbl);
            this.Controls.Add(this.recipeSelectionLbl);
            this.Controls.Add(this.recipeFileCheckbox);
            this.Name = "dishCreationForm";
            this.Text = "Create A Dish";
            this.Load += new System.EventHandler(this.dishCreationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openRecipeDialog;
        private System.Windows.Forms.CheckedListBox recipeFileCheckbox;
        private System.Windows.Forms.Label recipeSelectionLbl;
        private System.Windows.Forms.Label dishNamelbl;
        private System.Windows.Forms.TextBox dishNameTxtBox;
        private System.Windows.Forms.Button createDishBtn;
    }
}
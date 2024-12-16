using AccurateRecipeRecordingandCalculationSoftware.Properties;
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
            openRecipeDialog = new System.Windows.Forms.OpenFileDialog();
            recipeFileCheckbox = new System.Windows.Forms.CheckedListBox();
            recipeSelectionLbl = new System.Windows.Forms.Label();
            dishNamelbl = new System.Windows.Forms.Label();
            dishNameTxtBox = new System.Windows.Forms.TextBox();
            createDishBtn = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // openRecipeDialog
            // 
            openRecipeDialog.Multiselect = true;
            // 
            // recipeFileCheckbox
            // 
            recipeFileCheckbox.FormattingEnabled = true;
            recipeFileCheckbox.Location = new System.Drawing.Point(89, 214);
            recipeFileCheckbox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            recipeFileCheckbox.Name = "recipeFileCheckbox";
            recipeFileCheckbox.Size = new System.Drawing.Size(301, 228);
            recipeFileCheckbox.TabIndex = 0;
            // 
            // recipeSelectionLbl
            // 
            recipeSelectionLbl.AutoSize = true;
            recipeSelectionLbl.BackColor = System.Drawing.Color.Transparent;
            recipeSelectionLbl.Font = new System.Drawing.Font("Gentium Basic", 16F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, 0);
            recipeSelectionLbl.Location = new System.Drawing.Point(78, 151);
            recipeSelectionLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            recipeSelectionLbl.Name = "recipeSelectionLbl";
            recipeSelectionLbl.Size = new System.Drawing.Size(285, 37);
            recipeSelectionLbl.TabIndex = 1;
            recipeSelectionLbl.Text = "Select Your recipes\r\n";
            // 
            // dishNamelbl
            // 
            dishNamelbl.AutoSize = true;
            dishNamelbl.BackColor = System.Drawing.Color.Transparent;
            dishNamelbl.Font = new System.Drawing.Font("Gentium Basic", 14F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, 0);
            dishNamelbl.Location = new System.Drawing.Point(40, 49);
            dishNamelbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            dishNamelbl.Name = "dishNamelbl";
            dishNamelbl.Size = new System.Drawing.Size(153, 32);
            dishNamelbl.TabIndex = 2;
            dishNamelbl.Text = "Dish Name:";
            // 
            // dishNameTxtBox
            // 
            dishNameTxtBox.Location = new System.Drawing.Point(210, 50);
            dishNameTxtBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            dishNameTxtBox.Name = "dishNameTxtBox";
            dishNameTxtBox.Size = new System.Drawing.Size(164, 31);
            dishNameTxtBox.TabIndex = 3;
            // 
            // createDishBtn
            // 
            createDishBtn.Location = new System.Drawing.Point(171, 493);
            createDishBtn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            createDishBtn.Name = "createDishBtn";
            createDishBtn.Size = new System.Drawing.Size(125, 44);
            createDishBtn.TabIndex = 4;
            createDishBtn.Text = "Create Dish";
            createDishBtn.UseVisualStyleBackColor = true;
            createDishBtn.Click += createDishBtn_Click;
            // 
            // dishCreationForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = Resources.linedpaperbackground;
            ClientSize = new System.Drawing.Size(473, 552);
            Controls.Add(createDishBtn);
            Controls.Add(dishNameTxtBox);
            Controls.Add(dishNamelbl);
            Controls.Add(recipeSelectionLbl);
            Controls.Add(recipeFileCheckbox);
            Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            Name = "dishCreationForm";
            Text = "Create A Dish";
            Load += dishCreationForm_Load;
            ResumeLayout(false);
            PerformLayout();
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
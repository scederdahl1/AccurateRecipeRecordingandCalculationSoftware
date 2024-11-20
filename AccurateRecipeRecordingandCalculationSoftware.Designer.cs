namespace AccurateRecipeRecordingandCalculationSoftware
{
    partial class AccurateRecipeRecordingandCalculationSoftware
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
            this.recipeOptionPanel = new System.Windows.Forms.Panel();
            this.recipeCreationLabell = new System.Windows.Forms.LinkLabel();
            this.dishOptionPanel = new System.Windows.Forms.Panel();
            this.createDishLabel = new System.Windows.Forms.LinkLabel();
            this.recipeListBox1 = new System.Windows.Forms.ListBox();
            this.existingRecipeslbl = new System.Windows.Forms.Label();
            this.dishFileListBox = new System.Windows.Forms.ListBox();
            this.existingDishlbl = new System.Windows.Forms.Label();
            this.culinaCalcDBLbl = new System.Windows.Forms.Label();
            this.recipeOptionPanel.SuspendLayout();
            this.dishOptionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // recipeOptionPanel
            // 
            this.recipeOptionPanel.Controls.Add(this.existingRecipeslbl);
            this.recipeOptionPanel.Controls.Add(this.recipeListBox1);
            this.recipeOptionPanel.Controls.Add(this.recipeCreationLabell);
            this.recipeOptionPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recipeOptionPanel.Location = new System.Drawing.Point(67, 166);
            this.recipeOptionPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.recipeOptionPanel.Name = "recipeOptionPanel";
            this.recipeOptionPanel.Size = new System.Drawing.Size(356, 302);
            this.recipeOptionPanel.TabIndex = 0;
            // 
            // recipeCreationLabell
            // 
            this.recipeCreationLabell.AutoSize = true;
            this.recipeCreationLabell.Location = new System.Drawing.Point(24, 147);
            this.recipeCreationLabell.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.recipeCreationLabell.Name = "recipeCreationLabell";
            this.recipeCreationLabell.Size = new System.Drawing.Size(310, 37);
            this.recipeCreationLabell.TabIndex = 0;
            this.recipeCreationLabell.TabStop = true;
            this.recipeCreationLabell.Text = "+Create New Recipe";
            this.recipeCreationLabell.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.recipeCreationLabell_LinkClicked);
            // 
            // dishOptionPanel
            // 
            this.dishOptionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dishOptionPanel.Controls.Add(this.existingDishlbl);
            this.dishOptionPanel.Controls.Add(this.dishFileListBox);
            this.dishOptionPanel.Controls.Add(this.createDishLabel);
            this.dishOptionPanel.Location = new System.Drawing.Point(639, 166);
            this.dishOptionPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dishOptionPanel.Name = "dishOptionPanel";
            this.dishOptionPanel.Size = new System.Drawing.Size(378, 293);
            this.dishOptionPanel.TabIndex = 1;
            // 
            // createDishLabel
            // 
            this.createDishLabel.AutoSize = true;
            this.createDishLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createDishLabel.Location = new System.Drawing.Point(55, 137);
            this.createDishLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.createDishLabel.Name = "createDishLabel";
            this.createDishLabel.Size = new System.Drawing.Size(258, 37);
            this.createDishLabel.TabIndex = 0;
            this.createDishLabel.TabStop = true;
            this.createDishLabel.Text = "Create New Dish";
            this.createDishLabel.Visible = false;
            this.createDishLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createDishLabel_LinkClicked);
            // 
            // recipeListBox1
            // 
            this.recipeListBox1.FormattingEnabled = true;
            this.recipeListBox1.ItemHeight = 37;
            this.recipeListBox1.Location = new System.Drawing.Point(31, 92);
            this.recipeListBox1.Name = "recipeListBox1";
            this.recipeListBox1.Size = new System.Drawing.Size(295, 152);
            this.recipeListBox1.TabIndex = 1;
            this.recipeListBox1.Visible = false;
            // 
            // existingRecipeslbl
            // 
            this.existingRecipeslbl.AutoSize = true;
            this.existingRecipeslbl.Font = new System.Drawing.Font("Gentium Basic", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.existingRecipeslbl.Location = new System.Drawing.Point(50, 27);
            this.existingRecipeslbl.Name = "existingRecipeslbl";
            this.existingRecipeslbl.Size = new System.Drawing.Size(201, 32);
            this.existingRecipeslbl.TabIndex = 2;
            this.existingRecipeslbl.Text = "Existing Recipes";
            // 
            // dishFileListBox
            // 
            this.dishFileListBox.FormattingEnabled = true;
            this.dishFileListBox.ItemHeight = 20;
            this.dishFileListBox.Location = new System.Drawing.Point(22, 83);
            this.dishFileListBox.Name = "dishFileListBox";
            this.dishFileListBox.Size = new System.Drawing.Size(295, 164);
            this.dishFileListBox.TabIndex = 2;
            this.dishFileListBox.Visible = false;
            // 
            // existingDishlbl
            // 
            this.existingDishlbl.AutoSize = true;
            this.existingDishlbl.Font = new System.Drawing.Font("Gentium Basic", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.existingDishlbl.Location = new System.Drawing.Point(56, 18);
            this.existingDishlbl.Name = "existingDishlbl";
            this.existingDishlbl.Size = new System.Drawing.Size(188, 32);
            this.existingDishlbl.TabIndex = 3;
            this.existingDishlbl.Text = "Existing Dishes";
            // 
            // culinaCalcDBLbl
            // 
            this.culinaCalcDBLbl.AutoSize = true;
            this.culinaCalcDBLbl.Font = new System.Drawing.Font("Gentium Basic", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.culinaCalcDBLbl.Location = new System.Drawing.Point(370, 69);
            this.culinaCalcDBLbl.Name = "culinaCalcDBLbl";
            this.culinaCalcDBLbl.Size = new System.Drawing.Size(323, 37);
            this.culinaCalcDBLbl.TabIndex = 2;
            this.culinaCalcDBLbl.Text = "CulinaCalc Dashboard";
            // 
            // AccurateRecipeRecordingandCalculationSoftware
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 692);
            this.Controls.Add(this.culinaCalcDBLbl);
            this.Controls.Add(this.dishOptionPanel);
            this.Controls.Add(this.recipeOptionPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AccurateRecipeRecordingandCalculationSoftware";
            this.Text = "CulinaCalc";
            this.Load += new System.EventHandler(this.AccurateRecipeRecordingandCalculationSoftware_Load);
            this.recipeOptionPanel.ResumeLayout(false);
            this.recipeOptionPanel.PerformLayout();
            this.dishOptionPanel.ResumeLayout(false);
            this.dishOptionPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel recipeOptionPanel;
        private System.Windows.Forms.Panel dishOptionPanel;
        private System.Windows.Forms.LinkLabel recipeCreationLabell;
        private System.Windows.Forms.LinkLabel createDishLabel;
        private System.Windows.Forms.ListBox recipeListBox1;
        private System.Windows.Forms.Label existingRecipeslbl;
        private System.Windows.Forms.Label existingDishlbl;
        private System.Windows.Forms.ListBox dishFileListBox;
        private System.Windows.Forms.Label culinaCalcDBLbl;
    }
}


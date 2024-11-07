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
            this.testcookingPanel = new System.Windows.Forms.Panel();
            this.recipeOptionPanel.SuspendLayout();
            this.dishOptionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // recipeOptionPanel
            // 
            this.recipeOptionPanel.Controls.Add(this.recipeCreationLabell);
            this.recipeOptionPanel.Location = new System.Drawing.Point(12, 12);
            this.recipeOptionPanel.Name = "recipeOptionPanel";
            this.recipeOptionPanel.Size = new System.Drawing.Size(237, 156);
            this.recipeOptionPanel.TabIndex = 0;
            // 
            // recipeCreationLabell
            // 
            this.recipeCreationLabell.AutoSize = true;
            this.recipeCreationLabell.Location = new System.Drawing.Point(44, 79);
            this.recipeCreationLabell.Name = "recipeCreationLabell";
            this.recipeCreationLabell.Size = new System.Drawing.Size(106, 13);
            this.recipeCreationLabell.TabIndex = 0;
            this.recipeCreationLabell.TabStop = true;
            this.recipeCreationLabell.Text = "+Create New Recipe";
            this.recipeCreationLabell.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.recipeCreationLabell_LinkClicked);
            // 
            // dishOptionPanel
            // 
            this.dishOptionPanel.Controls.Add(this.createDishLabel);
            this.dishOptionPanel.Location = new System.Drawing.Point(439, 12);
            this.dishOptionPanel.Name = "dishOptionPanel";
            this.dishOptionPanel.Size = new System.Drawing.Size(237, 136);
            this.dishOptionPanel.TabIndex = 1;
            // 
            // createDishLabel
            // 
            this.createDishLabel.AutoSize = true;
            this.createDishLabel.Location = new System.Drawing.Point(78, 79);
            this.createDishLabel.Name = "createDishLabel";
            this.createDishLabel.Size = new System.Drawing.Size(87, 13);
            this.createDishLabel.TabIndex = 0;
            this.createDishLabel.TabStop = true;
            this.createDishLabel.Text = "Create New Dish";
            this.createDishLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createDishLabel_LinkClicked);
            // 
            // testcookingPanel
            // 
            this.testcookingPanel.Location = new System.Drawing.Point(12, 174);
            this.testcookingPanel.Name = "testcookingPanel";
            this.testcookingPanel.Size = new System.Drawing.Size(237, 197);
            this.testcookingPanel.TabIndex = 2;
            // 
            // AccurateRecipeRecordingandCalculationSoftware
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.testcookingPanel);
            this.Controls.Add(this.dishOptionPanel);
            this.Controls.Add(this.recipeOptionPanel);
            this.Name = "AccurateRecipeRecordingandCalculationSoftware";
            this.Text = "Name(TBD)";
            this.Load += new System.EventHandler(this.AccurateRecipeRecordingandCalculationSoftware_Load);
            this.recipeOptionPanel.ResumeLayout(false);
            this.recipeOptionPanel.PerformLayout();
            this.dishOptionPanel.ResumeLayout(false);
            this.dishOptionPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel recipeOptionPanel;
        private System.Windows.Forms.Panel dishOptionPanel;
        private System.Windows.Forms.Panel testcookingPanel;
        private System.Windows.Forms.LinkLabel recipeCreationLabell;
        private System.Windows.Forms.LinkLabel createDishLabel;
    }
}


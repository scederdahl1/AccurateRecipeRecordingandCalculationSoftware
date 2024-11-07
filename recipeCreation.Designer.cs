namespace AccurateRecipeRecordingandCalculationSoftware
{
    partial class recipeCreation
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
            this.recipeCreatorLabel = new System.Windows.Forms.Label();
            this.recipeTitlebox = new System.Windows.Forms.TextBox();
            this.ingredientsLabel = new System.Windows.Forms.Label();
            this.ingredientDatagrid1 = new System.Windows.Forms.DataGridView();
            this.ingredientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingredientPreparation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingredientAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingredientCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cookingStepGrid = new System.Windows.Forms.DataGridView();
            this.cookingStepNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cookingStepTIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cookingStepInstructions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.recipeServingsLabel = new System.Windows.Forms.Label();
            this.recipeServingsTextbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientDatagrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cookingStepGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // recipeCreatorLabel
            // 
            this.recipeCreatorLabel.AutoSize = true;
            this.recipeCreatorLabel.Location = new System.Drawing.Point(44, 51);
            this.recipeCreatorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.recipeCreatorLabel.Name = "recipeCreatorLabel";
            this.recipeCreatorLabel.Size = new System.Drawing.Size(67, 13);
            this.recipeCreatorLabel.TabIndex = 0;
            this.recipeCreatorLabel.Text = "Recipe Title:";
            // 
            // recipeTitlebox
            // 
            this.recipeTitlebox.Location = new System.Drawing.Point(115, 48);
            this.recipeTitlebox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.recipeTitlebox.Name = "recipeTitlebox";
            this.recipeTitlebox.Size = new System.Drawing.Size(68, 20);
            this.recipeTitlebox.TabIndex = 7;
            // 
            // ingredientsLabel
            // 
            this.ingredientsLabel.AutoSize = true;
            this.ingredientsLabel.Location = new System.Drawing.Point(260, 100);
            this.ingredientsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ingredientsLabel.Name = "ingredientsLabel";
            this.ingredientsLabel.Size = new System.Drawing.Size(59, 13);
            this.ingredientsLabel.TabIndex = 1;
            this.ingredientsLabel.Text = "Ingredients";
            // 
            // ingredientDatagrid1
            // 
            this.ingredientDatagrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ingredientDatagrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ingredientName,
            this.ingredientPreparation,
            this.ingredientAmount,
            this.ingredientCost});
            this.ingredientDatagrid1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.ingredientDatagrid1.Location = new System.Drawing.Point(61, 130);
            this.ingredientDatagrid1.Name = "ingredientDatagrid1";
            this.ingredientDatagrid1.RowHeadersWidth = 62;
            this.ingredientDatagrid1.Size = new System.Drawing.Size(363, 127);
            this.ingredientDatagrid1.TabIndex = 8;
            // 
            // ingredientName
            // 
            this.ingredientName.HeaderText = "Name";
            this.ingredientName.MinimumWidth = 8;
            this.ingredientName.Name = "ingredientName";
            this.ingredientName.Width = 75;
            // 
            // ingredientPreparation
            // 
            this.ingredientPreparation.HeaderText = "Preparation";
            this.ingredientPreparation.MinimumWidth = 8;
            this.ingredientPreparation.Name = "ingredientPreparation";
            this.ingredientPreparation.Width = 75;
            // 
            // ingredientAmount
            // 
            this.ingredientAmount.HeaderText = "Amount";
            this.ingredientAmount.MinimumWidth = 8;
            this.ingredientAmount.Name = "ingredientAmount";
            this.ingredientAmount.Width = 75;
            // 
            // ingredientCost
            // 
            this.ingredientCost.HeaderText = "Cost";
            this.ingredientCost.MinimumWidth = 8;
            this.ingredientCost.Name = "ingredientCost";
            this.ingredientCost.Width = 75;
            // 
            // cookingStepGrid
            // 
            this.cookingStepGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cookingStepGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cookingStepNumber,
            this.cookingStepTIme,
            this.cookingStepInstructions});
            this.cookingStepGrid.Location = new System.Drawing.Point(12, 294);
            this.cookingStepGrid.Name = "cookingStepGrid";
            this.cookingStepGrid.RowHeadersWidth = 62;
            this.cookingStepGrid.Size = new System.Drawing.Size(343, 150);
            this.cookingStepGrid.TabIndex = 9;
            // 
            // cookingStepNumber
            // 
            this.cookingStepNumber.HeaderText = "Step#";
            this.cookingStepNumber.MinimumWidth = 8;
            this.cookingStepNumber.Name = "cookingStepNumber";
            this.cookingStepNumber.Width = 150;
            // 
            // cookingStepTIme
            // 
            this.cookingStepTIme.HeaderText = "Step Time";
            this.cookingStepTIme.MinimumWidth = 8;
            this.cookingStepTIme.Name = "cookingStepTIme";
            this.cookingStepTIme.Width = 150;
            // 
            // cookingStepInstructions
            // 
            this.cookingStepInstructions.HeaderText = "Instructions";
            this.cookingStepInstructions.MinimumWidth = 8;
            this.cookingStepInstructions.Name = "cookingStepInstructions";
            this.cookingStepInstructions.Width = 150;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(394, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // recipeServingsLabel
            // 
            this.recipeServingsLabel.AutoSize = true;
            this.recipeServingsLabel.Location = new System.Drawing.Point(228, 51);
            this.recipeServingsLabel.Name = "recipeServingsLabel";
            this.recipeServingsLabel.Size = new System.Drawing.Size(51, 13);
            this.recipeServingsLabel.TabIndex = 11;
            this.recipeServingsLabel.Text = "Servings:";
            // 
            // recipeServingsTextbox
            // 
            this.recipeServingsTextbox.Location = new System.Drawing.Point(285, 48);
            this.recipeServingsTextbox.Name = "recipeServingsTextbox";
            this.recipeServingsTextbox.Size = new System.Drawing.Size(34, 20);
            this.recipeServingsTextbox.TabIndex = 12;
            // 
            // recipeCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 456);
            this.Controls.Add(this.recipeServingsTextbox);
            this.Controls.Add(this.recipeServingsLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cookingStepGrid);
            this.Controls.Add(this.ingredientDatagrid1);
            this.Controls.Add(this.ingredientsLabel);
            this.Controls.Add(this.recipeCreatorLabel);
            this.Controls.Add(this.recipeTitlebox);
            this.Name = "recipeCreation";
            this.Text = "Create New Recipe";
            ((System.ComponentModel.ISupportInitialize)(this.ingredientDatagrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cookingStepGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label recipeCreatorLabel;
        private System.Windows.Forms.TextBox recipeTitlebox;
        private System.Windows.Forms.Label ingredientsLabel;
        private System.Windows.Forms.DataGridView ingredientDatagrid1;
        private System.Windows.Forms.DataGridView cookingStepGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cookingStepNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn cookingStepTIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn cookingStepInstructions;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingredientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingredientPreparation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingredientAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingredientCost;
        private System.Windows.Forms.Label recipeServingsLabel;
        private System.Windows.Forms.TextBox recipeServingsTextbox;
    }
}
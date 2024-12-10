using AccurateRecipeRecordingandCalculationSoftware.Properties;
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
            recipeCreatorLabel = new System.Windows.Forms.Label();
            recipeTitlebox = new System.Windows.Forms.TextBox();
            ingredientsLabel = new System.Windows.Forms.Label();
            ingredientDatagrid1 = new System.Windows.Forms.DataGridView();
            ingredientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ingredientPreparation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ingredientAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ingredientUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ingredientCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cookingStepGrid = new System.Windows.Forms.DataGridView();
            cookingStepNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cookingStepTIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cookingStepInstructions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            button1 = new System.Windows.Forms.Button();
            recipeServingsLabel = new System.Windows.Forms.Label();
            recipeServingsTextbox = new System.Windows.Forms.TextBox();
            csRecipeLbl = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            recipeCreationlbl = new System.Windows.Forms.Label();
            tomatoPBRC1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)ingredientDatagrid1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cookingStepGrid).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tomatoPBRC1).BeginInit();
            SuspendLayout();
            // 
            // recipeCreatorLabel
            // 
            recipeCreatorLabel.AutoSize = true;
            recipeCreatorLabel.BackColor = System.Drawing.Color.Transparent;
            recipeCreatorLabel.Location = new System.Drawing.Point(66, 22);
            recipeCreatorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            recipeCreatorLabel.Name = "recipeCreatorLabel";
            recipeCreatorLabel.Size = new System.Drawing.Size(167, 32);
            recipeCreatorLabel.TabIndex = 0;
            recipeCreatorLabel.Text = "Recipe Title:";
            // 
            // recipeTitlebox
            // 
            recipeTitlebox.Location = new System.Drawing.Point(241, 14);
            recipeTitlebox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            recipeTitlebox.Name = "recipeTitlebox";
            recipeTitlebox.Size = new System.Drawing.Size(164, 40);
            recipeTitlebox.TabIndex = 7;
            // 
            // ingredientsLabel
            // 
            ingredientsLabel.AutoSize = true;
            ingredientsLabel.BackColor = System.Drawing.Color.Transparent;
            ingredientsLabel.Font = new System.Drawing.Font("Gentium Basic", 14F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline);
            ingredientsLabel.Location = new System.Drawing.Point(301, 276);
            ingredientsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ingredientsLabel.Name = "ingredientsLabel";
            ingredientsLabel.Size = new System.Drawing.Size(156, 32);
            ingredientsLabel.TabIndex = 1;
            ingredientsLabel.Text = "Ingredients";
            // 
            // ingredientDatagrid1
            // 
            ingredientDatagrid1.BackgroundColor = System.Drawing.Color.White;
            ingredientDatagrid1.ColumnHeadersHeight = 34;
            ingredientDatagrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            ingredientDatagrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ingredientName, ingredientPreparation, ingredientAmount, ingredientUnit, ingredientCost });
            ingredientDatagrid1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            ingredientDatagrid1.Location = new System.Drawing.Point(12, 316);
            ingredientDatagrid1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            ingredientDatagrid1.Name = "ingredientDatagrid1";
            ingredientDatagrid1.RowHeadersWidth = 62;
            ingredientDatagrid1.Size = new System.Drawing.Size(790, 136);
            ingredientDatagrid1.TabIndex = 8;
            // 
            // ingredientName
            // 
            ingredientName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            ingredientName.HeaderText = "Name";
            ingredientName.MinimumWidth = 8;
            ingredientName.Name = "ingredientName";
            ingredientName.Width = 120;
            // 
            // ingredientPreparation
            // 
            ingredientPreparation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            ingredientPreparation.HeaderText = "Preparation";
            ingredientPreparation.MinimumWidth = 8;
            ingredientPreparation.Name = "ingredientPreparation";
            ingredientPreparation.Width = 197;
            // 
            // ingredientAmount
            // 
            ingredientAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            ingredientAmount.HeaderText = "Amount";
            ingredientAmount.MinimumWidth = 8;
            ingredientAmount.Name = "ingredientAmount";
            ingredientAmount.Width = 148;
            // 
            // ingredientUnit
            // 
            ingredientUnit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            ingredientUnit.HeaderText = "Unit";
            ingredientUnit.MinimumWidth = 8;
            ingredientUnit.Name = "ingredientUnit";
            ingredientUnit.Width = 103;
            // 
            // ingredientCost
            // 
            ingredientCost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            ingredientCost.HeaderText = "Cost";
            ingredientCost.MinimumWidth = 8;
            ingredientCost.Name = "ingredientCost";
            ingredientCost.Width = 103;
            // 
            // cookingStepGrid
            // 
            cookingStepGrid.BackgroundColor = System.Drawing.Color.White;
            cookingStepGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cookingStepGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { cookingStepNumber, cookingStepTIme, cookingStepInstructions });
            cookingStepGrid.Location = new System.Drawing.Point(79, 500);
            cookingStepGrid.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            cookingStepGrid.Name = "cookingStepGrid";
            cookingStepGrid.RowHeadersWidth = 62;
            cookingStepGrid.Size = new System.Drawing.Size(606, 139);
            cookingStepGrid.TabIndex = 9;
            // 
            // cookingStepNumber
            // 
            cookingStepNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            cookingStepNumber.HeaderText = "Step#";
            cookingStepNumber.MinimumWidth = 8;
            cookingStepNumber.Name = "cookingStepNumber";
            cookingStepNumber.Width = 118;
            // 
            // cookingStepTIme
            // 
            cookingStepTIme.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            cookingStepTIme.HeaderText = "Step Time";
            cookingStepTIme.MinimumWidth = 8;
            cookingStepTIme.Name = "cookingStepTIme";
            cookingStepTIme.Width = 172;
            // 
            // cookingStepInstructions
            // 
            cookingStepInstructions.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            cookingStepInstructions.HeaderText = "Instructions";
            cookingStepInstructions.MinimumWidth = 8;
            cookingStepInstructions.Name = "cookingStepInstructions";
            cookingStepInstructions.Width = 199;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(256, 646);
            button1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(220, 50);
            button1.TabIndex = 10;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // recipeServingsLabel
            // 
            recipeServingsLabel.AutoSize = true;
            recipeServingsLabel.BackColor = System.Drawing.Color.Transparent;
            recipeServingsLabel.Location = new System.Drawing.Point(80, 65);
            recipeServingsLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            recipeServingsLabel.Name = "recipeServingsLabel";
            recipeServingsLabel.Size = new System.Drawing.Size(127, 32);
            recipeServingsLabel.TabIndex = 11;
            recipeServingsLabel.Text = "Servings:";
            // 
            // recipeServingsTextbox
            // 
            recipeServingsTextbox.Location = new System.Drawing.Point(241, 57);
            recipeServingsTextbox.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            recipeServingsTextbox.Name = "recipeServingsTextbox";
            recipeServingsTextbox.Size = new System.Drawing.Size(79, 40);
            recipeServingsTextbox.TabIndex = 12;
            // 
            // csRecipeLbl
            // 
            csRecipeLbl.AutoSize = true;
            csRecipeLbl.BackColor = System.Drawing.Color.Transparent;
            csRecipeLbl.Font = new System.Drawing.Font("Gentium Basic", 14F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, 0);
            csRecipeLbl.Location = new System.Drawing.Point(289, 460);
            csRecipeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            csRecipeLbl.Name = "csRecipeLbl";
            csRecipeLbl.Size = new System.Drawing.Size(187, 32);
            csRecipeLbl.TabIndex = 13;
            csRecipeLbl.Text = "Cooking Steps";
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.Transparent;
            panel1.Controls.Add(recipeCreatorLabel);
            panel1.Controls.Add(recipeTitlebox);
            panel1.Controls.Add(recipeServingsTextbox);
            panel1.Controls.Add(recipeServingsLabel);
            panel1.Location = new System.Drawing.Point(65, 74);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(429, 154);
            panel1.TabIndex = 14;
            // 
            // recipeCreationlbl
            // 
            recipeCreationlbl.AutoSize = true;
            recipeCreationlbl.Font = new System.Drawing.Font("Gentium Basic", 20F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline);
            recipeCreationlbl.Location = new System.Drawing.Point(243, 9);
            recipeCreationlbl.Name = "recipeCreationlbl";
            recipeCreationlbl.Size = new System.Drawing.Size(354, 46);
            recipeCreationlbl.TabIndex = 17;
            recipeCreationlbl.Text = "Create Your Recipe";
            // 
            // tomatoPBRC1
            // 
            tomatoPBRC1.BackColor = System.Drawing.Color.Transparent;
            tomatoPBRC1.Image = Resources.tomatoeDrawn_removebg_preview;
            tomatoPBRC1.Location = new System.Drawing.Point(542, 58);
            tomatoPBRC1.Name = "tomatoPBRC1";
            tomatoPBRC1.Size = new System.Drawing.Size(223, 208);
            tomatoPBRC1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            tomatoPBRC1.TabIndex = 18;
            tomatoPBRC1.TabStop = false;
            // 
            // recipeCreation
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(15F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = Resources.linedpaperbackground;
            ClientSize = new System.Drawing.Size(817, 704);
            Controls.Add(tomatoPBRC1);
            Controls.Add(cookingStepGrid);
            Controls.Add(csRecipeLbl);
            Controls.Add(ingredientDatagrid1);
            Controls.Add(ingredientsLabel);
            Controls.Add(recipeCreationlbl);
            Controls.Add(panel1);
            Controls.Add(button1);
            Font = new System.Drawing.Font("Gentium Basic", 14F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline);
            Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            Name = "recipeCreation";
            Text = "Create New Recipe";
            Load += recipeCreation_Load;
            ((System.ComponentModel.ISupportInitialize)ingredientDatagrid1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cookingStepGrid).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tomatoPBRC1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label recipeCreatorLabel;
        private System.Windows.Forms.TextBox recipeTitlebox;
        private System.Windows.Forms.Label ingredientsLabel;
        private System.Windows.Forms.DataGridView ingredientDatagrid1;
        private System.Windows.Forms.DataGridView cookingStepGrid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label recipeServingsLabel;
        private System.Windows.Forms.TextBox recipeServingsTextbox;
        private System.Windows.Forms.Label csRecipeLbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn cookingStepNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn cookingStepTIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn cookingStepInstructions;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label recipeCreationlbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingredientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingredientPreparation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingredientAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingredientUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingredientCost;
        private System.Windows.Forms.PictureBox tomatoPBRC1;
    }
}
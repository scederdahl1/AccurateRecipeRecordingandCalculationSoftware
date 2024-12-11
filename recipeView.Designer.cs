using AccurateRecipeRecordingandCalculationSoftware.Properties;
namespace AccurateRecipeRecordingandCalculationSoftware
{
    partial class recipeView
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
            ingdgview = new System.Windows.Forms.DataGridView();
            recipeViewNamelbl = new System.Windows.Forms.Label();
            viewedRecipeStepsDG = new System.Windows.Forms.DataGridView();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)ingdgview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)viewedRecipeStepsDG).BeginInit();
            SuspendLayout();
            // 
            // ingdgview
            // 
            ingdgview.AllowUserToAddRows = false;
            ingdgview.AllowUserToDeleteRows = false;
            ingdgview.BackgroundColor = System.Drawing.Color.White;
            ingdgview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ingdgview.Location = new System.Drawing.Point(83, 141);
            ingdgview.Name = "ingdgview";
            ingdgview.ReadOnly = true;
            ingdgview.RowHeadersWidth = 62;
            ingdgview.Size = new System.Drawing.Size(590, 143);
            ingdgview.TabIndex = 0;
            // 
            // recipeViewNamelbl
            // 
            recipeViewNamelbl.AutoSize = true;
            recipeViewNamelbl.BackColor = System.Drawing.Color.Transparent;
            recipeViewNamelbl.Font = new System.Drawing.Font("Gentium Basic", 24F);
            recipeViewNamelbl.Location = new System.Drawing.Point(336, 51);
            recipeViewNamelbl.Name = "recipeViewNamelbl";
            recipeViewNamelbl.Size = new System.Drawing.Size(0, 56);
            recipeViewNamelbl.TabIndex = 1;
            // 
            // viewedRecipeStepsDG
            // 
            viewedRecipeStepsDG.AllowUserToAddRows = false;
            viewedRecipeStepsDG.AllowUserToDeleteRows = false;
            viewedRecipeStepsDG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            viewedRecipeStepsDG.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            viewedRecipeStepsDG.BackgroundColor = System.Drawing.Color.White;
            viewedRecipeStepsDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viewedRecipeStepsDG.Location = new System.Drawing.Point(83, 340);
            viewedRecipeStepsDG.Name = "viewedRecipeStepsDG";
            viewedRecipeStepsDG.ReadOnly = true;
            viewedRecipeStepsDG.RowHeadersWidth = 62;
            viewedRecipeStepsDG.Size = new System.Drawing.Size(650, 147);
            viewedRecipeStepsDG.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Gentium Basic", 14F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(155, 94);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(156, 32);
            label1.TabIndex = 3;
            label1.Text = "Ingredients";
            // 
            // recipeView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = Resources.linedpaperbackground;
            ClientSize = new System.Drawing.Size(941, 511);
            Controls.Add(label1);
            Controls.Add(viewedRecipeStepsDG);
            Controls.Add(recipeViewNamelbl);
            Controls.Add(ingdgview);
            Name = "recipeView";
            ((System.ComponentModel.ISupportInitialize)ingdgview).EndInit();
            ((System.ComponentModel.ISupportInitialize)viewedRecipeStepsDG).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView ingdgview;
        private System.Windows.Forms.Label recipeViewNamelbl;
        private System.Windows.Forms.DataGridView viewedRecipeStepsDG;
        private System.Windows.Forms.Label label1;
    }
}
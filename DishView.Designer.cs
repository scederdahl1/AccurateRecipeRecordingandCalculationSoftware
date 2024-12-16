using AccurateRecipeRecordingandCalculationSoftware.Properties;
namespace AccurateRecipeRecordingandCalculationSoftware
{
    partial class DishView
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
            dishNamelbl = new System.Windows.Forms.Label();
            tabControl1 = new System.Windows.Forms.TabControl();
            combinedStepsView = new System.Windows.Forms.DataGridView();
            ingredientListLbl = new System.Windows.Forms.Label();
            combinedStepslbl = new System.Windows.Forms.Label();
            dishLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)combinedStepsView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dishLogo).BeginInit();
            SuspendLayout();
            // 
            // dishNamelbl
            // 
            dishNamelbl.AutoSize = true;
            dishNamelbl.BackColor = System.Drawing.Color.Transparent;
            dishNamelbl.Font = new System.Drawing.Font("Gentium Basic", 16F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, 0);
            dishNamelbl.Location = new System.Drawing.Point(412, 9);
            dishNamelbl.Name = "dishNamelbl";
            dishNamelbl.Size = new System.Drawing.Size(156, 37);
            dishNamelbl.TabIndex = 0;
            dishNamelbl.Text = "dishName";
            // 
            // tabControl1
            // 
            tabControl1.Location = new System.Drawing.Point(12, 94);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(590, 195);
            tabControl1.TabIndex = 1;
            // 
            // combinedStepsView
            // 
            combinedStepsView.BackgroundColor = System.Drawing.Color.White;
            combinedStepsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            combinedStepsView.Location = new System.Drawing.Point(12, 345);
            combinedStepsView.Name = "combinedStepsView";
            combinedStepsView.RowHeadersWidth = 62;
            combinedStepsView.Size = new System.Drawing.Size(516, 225);
            combinedStepsView.TabIndex = 2;
            // 
            // ingredientListLbl
            // 
            ingredientListLbl.AutoSize = true;
            ingredientListLbl.BackColor = System.Drawing.Color.Transparent;
            ingredientListLbl.Font = new System.Drawing.Font("Gentium Basic", 14F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, 0);
            ingredientListLbl.Location = new System.Drawing.Point(183, 57);
            ingredientListLbl.Name = "ingredientListLbl";
            ingredientListLbl.Size = new System.Drawing.Size(226, 32);
            ingredientListLbl.TabIndex = 3;
            ingredientListLbl.Text = " Ingredients Lists";
            // 
            // combinedStepslbl
            // 
            combinedStepslbl.AutoSize = true;
            combinedStepslbl.BackColor = System.Drawing.Color.Transparent;
            combinedStepslbl.Font = new System.Drawing.Font("Gentium Basic", 14F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, 0);
            combinedStepslbl.Location = new System.Drawing.Point(92, 310);
            combinedStepslbl.Name = "combinedStepslbl";
            combinedStepslbl.Size = new System.Drawing.Size(317, 32);
            combinedStepslbl.TabIndex = 4;
            combinedStepslbl.Text = "Combined Cooking Steps";
            // 
            // dishLogo
            // 
            dishLogo.BackColor = System.Drawing.Color.Transparent;
            dishLogo.Image = Resources.logo;
            dishLogo.Location = new System.Drawing.Point(641, 113);
            dishLogo.Name = "dishLogo";
            dishLogo.Size = new System.Drawing.Size(263, 239);
            dishLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            dishLogo.TabIndex = 5;
            dishLogo.TabStop = false;
            // 
            // DishView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = Resources.linedpaperbackground;
            ClientSize = new System.Drawing.Size(941, 582);
            Controls.Add(dishLogo);
            Controls.Add(combinedStepslbl);
            Controls.Add(ingredientListLbl);
            Controls.Add(combinedStepsView);
            Controls.Add(tabControl1);
            Controls.Add(dishNamelbl);
            Name = "DishView";
            Text = "DishView";
            ((System.ComponentModel.ISupportInitialize)combinedStepsView).EndInit();
            ((System.ComponentModel.ISupportInitialize)dishLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label dishNamelbl;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DataGridView combinedStepsView;
        private System.Windows.Forms.Label ingredientListLbl;
        private System.Windows.Forms.Label combinedStepslbl;
        private System.Windows.Forms.PictureBox dishLogo;
    }
}
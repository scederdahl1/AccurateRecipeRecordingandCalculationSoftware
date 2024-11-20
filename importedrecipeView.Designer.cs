namespace AccurateRecipeRecordingandCalculationSoftware
{
    partial class loadedRecipeView
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
            this.loadedRecipeIngredientsLbl = new System.Windows.Forms.Label();
            this.ingredientRichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // loadedRecipeIngredientsLbl
            // 
            this.loadedRecipeIngredientsLbl.AutoSize = true;
            this.loadedRecipeIngredientsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadedRecipeIngredientsLbl.Location = new System.Drawing.Point(78, 54);
            this.loadedRecipeIngredientsLbl.Name = "loadedRecipeIngredientsLbl";
            this.loadedRecipeIngredientsLbl.Size = new System.Drawing.Size(166, 32);
            this.loadedRecipeIngredientsLbl.TabIndex = 0;
            this.loadedRecipeIngredientsLbl.Text = "Ingredients";
            // 
            // ingredientRichTextBox1
            // 
            this.ingredientRichTextBox1.Location = new System.Drawing.Point(31, 105);
            this.ingredientRichTextBox1.Name = "ingredientRichTextBox1";
            this.ingredientRichTextBox1.Size = new System.Drawing.Size(269, 235);
            this.ingredientRichTextBox1.TabIndex = 1;
            this.ingredientRichTextBox1.Text = "";
            // 
            // loadedRecipeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ingredientRichTextBox1);
            this.Controls.Add(this.loadedRecipeIngredientsLbl);
            this.Name = "loadedRecipeView";
            this.Text = "Recipe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loadedRecipeIngredientsLbl;
        private System.Windows.Forms.RichTextBox ingredientRichTextBox1;
    }
}
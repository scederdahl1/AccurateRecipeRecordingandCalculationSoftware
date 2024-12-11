using AccurateRecipeRecordingandCalculationSoftware.Properties;

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
            recipeOptionPanel = new System.Windows.Forms.Panel();
            existingRecipeslbl = new System.Windows.Forms.Label();
            recipeListBox1 = new System.Windows.Forms.ListBox();
            recipeCreationLabell = new System.Windows.Forms.LinkLabel();
            dishOptionPanel = new System.Windows.Forms.Panel();
            existingDishlbl = new System.Windows.Forms.Label();
            dishFileListBox = new System.Windows.Forms.ListBox();
            createDishLabel = new System.Windows.Forms.LinkLabel();
            culinaCalcDBLbl = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            sessionListbox = new System.Windows.Forms.ListBox();
            newCookingSessionlnklbl = new System.Windows.Forms.LinkLabel();
            DashboardRamenpb1 = new System.Windows.Forms.PictureBox();
            recipeOptionPanel.SuspendLayout();
            dishOptionPanel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DashboardRamenpb1).BeginInit();
            SuspendLayout();
            // 
            // recipeOptionPanel
            // 
            recipeOptionPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            recipeOptionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            recipeOptionPanel.Controls.Add(existingRecipeslbl);
            recipeOptionPanel.Controls.Add(recipeListBox1);
            recipeOptionPanel.Controls.Add(recipeCreationLabell);
            recipeOptionPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            recipeOptionPanel.Location = new System.Drawing.Point(9, 79);
            recipeOptionPanel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            recipeOptionPanel.Name = "recipeOptionPanel";
            recipeOptionPanel.Size = new System.Drawing.Size(350, 229);
            recipeOptionPanel.TabIndex = 0;
            // 
            // existingRecipeslbl
            // 
            existingRecipeslbl.AutoSize = true;
            existingRecipeslbl.Font = new System.Drawing.Font("Gentium Basic", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, 0);
            existingRecipeslbl.Location = new System.Drawing.Point(79, 0);
            existingRecipeslbl.Name = "existingRecipeslbl";
            existingRecipeslbl.Size = new System.Drawing.Size(201, 32);
            existingRecipeslbl.TabIndex = 2;
            existingRecipeslbl.Text = "Existing Recipes";
            // 
            // recipeListBox1
            // 
            recipeListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            recipeListBox1.FormattingEnabled = true;
            recipeListBox1.Location = new System.Drawing.Point(10, 36);
            recipeListBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            recipeListBox1.Name = "recipeListBox1";
            recipeListBox1.Size = new System.Drawing.Size(327, 114);
            recipeListBox1.TabIndex = 1;
            recipeListBox1.Visible = false;
            recipeListBox1.SelectedIndexChanged += recipeListBox1_SelectedIndexChanged;
            // 
            // recipeCreationLabell
            // 
            recipeCreationLabell.AutoSize = true;
            recipeCreationLabell.Font = new System.Drawing.Font("Gentium Basic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            recipeCreationLabell.Location = new System.Drawing.Point(27, 170);
            recipeCreationLabell.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            recipeCreationLabell.Name = "recipeCreationLabell";
            recipeCreationLabell.Size = new System.Drawing.Size(264, 37);
            recipeCreationLabell.TabIndex = 0;
            recipeCreationLabell.TabStop = true;
            recipeCreationLabell.Text = "Create New Recipe";
            recipeCreationLabell.LinkClicked += recipeCreationLabell_LinkClicked;
            // 
            // dishOptionPanel
            // 
            dishOptionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dishOptionPanel.Controls.Add(existingDishlbl);
            dishOptionPanel.Controls.Add(dishFileListBox);
            dishOptionPanel.Controls.Add(createDishLabel);
            dishOptionPanel.Location = new System.Drawing.Point(369, 80);
            dishOptionPanel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            dishOptionPanel.Name = "dishOptionPanel";
            dishOptionPanel.Size = new System.Drawing.Size(348, 228);
            dishOptionPanel.TabIndex = 1;
            // 
            // existingDishlbl
            // 
            existingDishlbl.AutoSize = true;
            existingDishlbl.Font = new System.Drawing.Font("Gentium Basic", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, 0);
            existingDishlbl.Location = new System.Drawing.Point(87, -1);
            existingDishlbl.Name = "existingDishlbl";
            existingDishlbl.Size = new System.Drawing.Size(188, 32);
            existingDishlbl.TabIndex = 3;
            existingDishlbl.Text = "Existing Dishes";
            // 
            // dishFileListBox
            // 
            dishFileListBox.FormattingEnabled = true;
            dishFileListBox.Location = new System.Drawing.Point(8, 36);
            dishFileListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dishFileListBox.Name = "dishFileListBox";
            dishFileListBox.Size = new System.Drawing.Size(327, 104);
            dishFileListBox.TabIndex = 2;
            dishFileListBox.Visible = false;
            // 
            // createDishLabel
            // 
            createDishLabel.AutoSize = true;
            createDishLabel.Font = new System.Drawing.Font("Gentium Basic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            createDishLabel.Location = new System.Drawing.Point(34, 169);
            createDishLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            createDishLabel.Name = "createDishLabel";
            createDishLabel.Size = new System.Drawing.Size(234, 37);
            createDishLabel.TabIndex = 0;
            createDishLabel.TabStop = true;
            createDishLabel.Text = "Create New Dish";
            createDishLabel.Visible = false;
            createDishLabel.LinkClicked += createDishLabel_LinkClicked;
            // 
            // culinaCalcDBLbl
            // 
            culinaCalcDBLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            culinaCalcDBLbl.AutoSize = true;
            culinaCalcDBLbl.Font = new System.Drawing.Font("Gentium Basic", 16F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, 0);
            culinaCalcDBLbl.Location = new System.Drawing.Point(211, 20);
            culinaCalcDBLbl.Name = "culinaCalcDBLbl";
            culinaCalcDBLbl.Size = new System.Drawing.Size(323, 37);
            culinaCalcDBLbl.TabIndex = 2;
            culinaCalcDBLbl.Text = "CulinaCalc Dashboard";
            // 
            // panel1
            // 
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(sessionListbox);
            panel1.Controls.Add(newCookingSessionlnklbl);
            panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            panel1.Location = new System.Drawing.Point(9, 316);
            panel1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(350, 229);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Gentium Basic", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(80, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(209, 32);
            label1.TabIndex = 2;
            label1.Text = "Existing Sessions";
            // 
            // sessionListbox
            // 
            sessionListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            sessionListbox.FormattingEnabled = true;
            sessionListbox.Location = new System.Drawing.Point(22, 36);
            sessionListbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            sessionListbox.Name = "sessionListbox";
            sessionListbox.Size = new System.Drawing.Size(306, 120);
            sessionListbox.TabIndex = 1;
            sessionListbox.Visible = false;
            // 
            // newCookingSessionlnklbl
            // 
            newCookingSessionlnklbl.AutoSize = true;
            newCookingSessionlnklbl.Font = new System.Drawing.Font("Gentium Basic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            newCookingSessionlnklbl.Location = new System.Drawing.Point(57, 172);
            newCookingSessionlnklbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            newCookingSessionlnklbl.Name = "newCookingSessionlnklbl";
            newCookingSessionlnklbl.Size = new System.Drawing.Size(196, 28);
            newCookingSessionlnklbl.TabIndex = 0;
            newCookingSessionlnklbl.TabStop = true;
            newCookingSessionlnklbl.Text = "New Session Recap";
            newCookingSessionlnklbl.LinkClicked += newCookingSessionlnklbl_LinkClicked;
            // 
            // DashboardRamenpb1
            // 
            DashboardRamenpb1.Image = Resources.projRamenBowl;
            DashboardRamenpb1.Location = new System.Drawing.Point(404, 317);
            DashboardRamenpb1.Name = "DashboardRamenpb1";
            DashboardRamenpb1.Size = new System.Drawing.Size(250, 228);
            DashboardRamenpb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            DashboardRamenpb1.TabIndex = 4;
            DashboardRamenpb1.TabStop = false;
            // 
            // AccurateRecipeRecordingandCalculationSoftware
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(790, 556);
            Controls.Add(DashboardRamenpb1);
            Controls.Add(panel1);
            Controls.Add(culinaCalcDBLbl);
            Controls.Add(dishOptionPanel);
            Controls.Add(recipeOptionPanel);
            Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            MaximumSize = new System.Drawing.Size(1000, 1000);
            Name = "AccurateRecipeRecordingandCalculationSoftware";
            Text = "CulinaCalc";
            Load += AccurateRecipeRecordingandCalculationSoftware_Load;
            recipeOptionPanel.ResumeLayout(false);
            recipeOptionPanel.PerformLayout();
            dishOptionPanel.ResumeLayout(false);
            dishOptionPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DashboardRamenpb1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox sessionListbox;
        private System.Windows.Forms.LinkLabel newCookingSessionlnklbl;
        private System.Windows.Forms.PictureBox DashboardRamenpb1;
    }
}


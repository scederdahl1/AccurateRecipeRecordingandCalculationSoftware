namespace AccurateRecipeRecordingandCalculationSoftware
{
    partial class TestcookingSessionEntryForm
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
            cookingSeshRTB1 = new System.Windows.Forms.RichTextBox();
            label1 = new System.Windows.Forms.Label();
            testCookingSessionDTP = new System.Windows.Forms.DateTimePicker();
            selectAssociateFileslbl = new System.Windows.Forms.LinkLabel();
            sessionSaveBtn = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // cookingSeshRTB1
            // 
            cookingSeshRTB1.Location = new System.Drawing.Point(53, 174);
            cookingSeshRTB1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            cookingSeshRTB1.Name = "cookingSeshRTB1";
            cookingSeshRTB1.Size = new System.Drawing.Size(447, 269);
            cookingSeshRTB1.TabIndex = 0;
            cookingSeshRTB1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Gentium Basic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(12, 39);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(151, 28);
            label1.TabIndex = 1;
            label1.Text = "Session Date:";
            // 
            // testCookingSessionDTP
            // 
            testCookingSessionDTP.Location = new System.Drawing.Point(169, 39);
            testCookingSessionDTP.Name = "testCookingSessionDTP";
            testCookingSessionDTP.Size = new System.Drawing.Size(300, 31);
            testCookingSessionDTP.TabIndex = 2;
            // 
            // selectAssociateFileslbl
            // 
            selectAssociateFileslbl.AutoSize = true;
            selectAssociateFileslbl.Location = new System.Drawing.Point(42, 102);
            selectAssociateFileslbl.Name = "selectAssociateFileslbl";
            selectAssociateFileslbl.Size = new System.Drawing.Size(206, 25);
            selectAssociateFileslbl.TabIndex = 3;
            selectAssociateFileslbl.TabStop = true;
            selectAssociateFileslbl.Text = "Select Recipes or Dishes ";
            selectAssociateFileslbl.LinkClicked += selectAssociateFileslbl_LinkClicked;
            // 
            // sessionSaveBtn
            // 
            sessionSaveBtn.Location = new System.Drawing.Point(199, 462);
            sessionSaveBtn.Name = "sessionSaveBtn";
            sessionSaveBtn.Size = new System.Drawing.Size(112, 34);
            sessionSaveBtn.TabIndex = 4;
            sessionSaveBtn.Text = "Submit";
            sessionSaveBtn.UseVisualStyleBackColor = true;
            // 
            // TestcookingSessionEntryForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(628, 508);
            Controls.Add(sessionSaveBtn);
            Controls.Add(selectAssociateFileslbl);
            Controls.Add(testCookingSessionDTP);
            Controls.Add(label1);
            Controls.Add(cookingSeshRTB1);
            Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            Name = "TestcookingSessionEntryForm";
            Text = "Test Cooking Session";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.RichTextBox cookingSeshRTB1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker testCookingSessionDTP;
        private System.Windows.Forms.LinkLabel selectAssociateFileslbl;
        private System.Windows.Forms.Button sessionSaveBtn;
    }
}
using AccurateRecipeRecordingandCalculationSoftware.Properties;
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
            sessionDateLbl = new System.Windows.Forms.Label();
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
            // sessionDateLbl
            // 
            sessionDateLbl.AutoSize = true;
            sessionDateLbl.BackColor = System.Drawing.Color.Transparent;
            sessionDateLbl.Font = new System.Drawing.Font("Gentium Basic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            sessionDateLbl.Location = new System.Drawing.Point(12, 39);
            sessionDateLbl.Name = "sessionDateLbl";
            sessionDateLbl.Size = new System.Drawing.Size(176, 32);
            sessionDateLbl.TabIndex = 1;
            sessionDateLbl.Text = "Session Date:";
            // 
            // testCookingSessionDTP
            // 
            testCookingSessionDTP.Location = new System.Drawing.Point(199, 38);
            testCookingSessionDTP.Name = "testCookingSessionDTP";
            testCookingSessionDTP.Size = new System.Drawing.Size(300, 31);
            testCookingSessionDTP.TabIndex = 2;
            // 
            // selectAssociateFileslbl
            // 
            selectAssociateFileslbl.AutoSize = true;
            selectAssociateFileslbl.BackColor = System.Drawing.Color.Transparent;
            selectAssociateFileslbl.Font = new System.Drawing.Font("Gentium Basic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            selectAssociateFileslbl.Location = new System.Drawing.Point(42, 102);
            selectAssociateFileslbl.Name = "selectAssociateFileslbl";
            selectAssociateFileslbl.Size = new System.Drawing.Size(234, 25);
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
            sessionSaveBtn.Click += sessionSaveBtn_Click;
            // 
            // TestcookingSessionEntryForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = Resources.linedpaperbackground;
            ClientSize = new System.Drawing.Size(628, 508);
            Controls.Add(sessionSaveBtn);
            Controls.Add(selectAssociateFileslbl);
            Controls.Add(testCookingSessionDTP);
            Controls.Add(sessionDateLbl);
            Controls.Add(cookingSeshRTB1);
            Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            Name = "TestcookingSessionEntryForm";
            Text = "Test Cooking Session";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.RichTextBox cookingSeshRTB1;
        private System.Windows.Forms.Label sessionDateLbl;
        private System.Windows.Forms.DateTimePicker testCookingSessionDTP;
        private System.Windows.Forms.LinkLabel selectAssociateFileslbl;
        private System.Windows.Forms.Button sessionSaveBtn;
    }
}
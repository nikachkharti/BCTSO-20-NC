namespace BankApp
{
    partial class Form2
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
            syncBtn = new Button();
            asyncBtn = new Button();
            SuspendLayout();
            // 
            // syncBtn
            // 
            syncBtn.Location = new Point(84, 151);
            syncBtn.Name = "syncBtn";
            syncBtn.Size = new Size(265, 34);
            syncBtn.TabIndex = 0;
            syncBtn.Text = "სინქრონული მუშაობა";
            syncBtn.UseVisualStyleBackColor = true;
            syncBtn.Click += syncBtn_Click;
            // 
            // asyncBtn
            // 
            asyncBtn.Location = new Point(413, 151);
            asyncBtn.Name = "asyncBtn";
            asyncBtn.Size = new Size(261, 34);
            asyncBtn.TabIndex = 0;
            asyncBtn.Text = "ასინქრონული მუშაობა";
            asyncBtn.UseVisualStyleBackColor = true;
            asyncBtn.Click += asyncBtn_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(asyncBtn);
            Controls.Add(syncBtn);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private Button syncBtn;
        private Button asyncBtn;
    }
}
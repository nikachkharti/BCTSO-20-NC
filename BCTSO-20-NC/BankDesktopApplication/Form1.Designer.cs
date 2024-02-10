namespace BankDesktopApplication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            peopleList = new ListBox();
            personNameValue = new TextBox();
            personNameLabel = new Label();
            ageValue = new TextBox();
            ageLabel = new Label();
            addButton = new Button();
            SuspendLayout();
            // 
            // peopleList
            // 
            peopleList.FormattingEnabled = true;
            peopleList.ItemHeight = 25;
            peopleList.Location = new Point(12, 12);
            peopleList.Name = "peopleList";
            peopleList.Size = new Size(544, 129);
            peopleList.TabIndex = 0;
            // 
            // personNameValue
            // 
            personNameValue.Location = new Point(12, 172);
            personNameValue.Name = "personNameValue";
            personNameValue.Size = new Size(323, 31);
            personNameValue.TabIndex = 1;
            // 
            // personNameLabel
            // 
            personNameLabel.AutoSize = true;
            personNameLabel.Location = new Point(12, 144);
            personNameLabel.Name = "personNameLabel";
            personNameLabel.Size = new Size(82, 25);
            personNameLabel.TabIndex = 2;
            personNameLabel.Text = "სახელი";
            // 
            // ageValue
            // 
            ageValue.Location = new Point(12, 261);
            ageValue.Name = "ageValue";
            ageValue.Size = new Size(323, 31);
            ageValue.TabIndex = 1;
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Location = new Point(12, 233);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new Size(61, 25);
            ageLabel.TabIndex = 2;
            ageLabel.Text = "ასაკი";
            // 
            // addButton
            // 
            addButton.Location = new Point(12, 313);
            addButton.Name = "addButton";
            addButton.Size = new Size(112, 34);
            addButton.TabIndex = 3;
            addButton.Text = "დამატება";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(800, 637);
            Controls.Add(addButton);
            Controls.Add(ageLabel);
            Controls.Add(personNameLabel);
            Controls.Add(ageValue);
            Controls.Add(personNameValue);
            Controls.Add(peopleList);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox peopleList;
        private TextBox personNameValue;
        private Label personNameLabel;
        private TextBox ageValue;
        private Label ageLabel;
        private Button addButton;
    }
}

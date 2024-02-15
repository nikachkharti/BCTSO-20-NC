namespace BankApp
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
            headerLabel = new Label();
            dataList = new ListBox();
            nameValue = new TextBox();
            nameLabel = new Label();
            identityNumberValue = new TextBox();
            identityNumberLabel = new Label();
            phoneValue = new TextBox();
            phoneNumberLabel = new Label();
            emailValue = new TextBox();
            emailLabel = new Label();
            typeValue = new TextBox();
            typeLabel = new Label();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            headerLabel.Location = new Point(419, 9);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(314, 48);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "მომხამრებლები";
            // 
            // dataList
            // 
            dataList.Cursor = Cursors.Hand;
            dataList.Dock = DockStyle.Bottom;
            dataList.FormattingEnabled = true;
            dataList.ItemHeight = 25;
            dataList.Location = new Point(0, 502);
            dataList.Name = "dataList";
            dataList.Size = new Size(1114, 279);
            dataList.TabIndex = 1;
            dataList.SelectedIndexChanged += dataList_SelectedIndexChanged;
            // 
            // nameValue
            // 
            nameValue.Location = new Point(12, 352);
            nameValue.Name = "nameValue";
            nameValue.Size = new Size(304, 31);
            nameValue.TabIndex = 2;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(12, 324);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(82, 25);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "სახელი";
            // 
            // identityNumberValue
            // 
            identityNumberValue.Location = new Point(322, 352);
            identityNumberValue.Name = "identityNumberValue";
            identityNumberValue.Size = new Size(304, 31);
            identityNumberValue.TabIndex = 2;
            // 
            // identityNumberLabel
            // 
            identityNumberLabel.AutoSize = true;
            identityNumberLabel.Location = new Point(322, 324);
            identityNumberLabel.Name = "identityNumberLabel";
            identityNumberLabel.Size = new Size(157, 25);
            identityNumberLabel.TabIndex = 3;
            identityNumberLabel.Text = "პირადი ნომერი";
            // 
            // phoneValue
            // 
            phoneValue.Location = new Point(632, 352);
            phoneValue.Name = "phoneValue";
            phoneValue.Size = new Size(304, 31);
            phoneValue.TabIndex = 2;
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new Point(632, 324);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(200, 25);
            phoneNumberLabel.TabIndex = 3;
            phoneNumberLabel.Text = "ტელეფონის ნომერი";
            // 
            // emailValue
            // 
            emailValue.Location = new Point(322, 414);
            emailValue.Name = "emailValue";
            emailValue.Size = new Size(304, 31);
            emailValue.TabIndex = 2;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(322, 386);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(111, 25);
            emailLabel.TabIndex = 3;
            emailLabel.Text = "ელ-ფოსტა";
            // 
            // typeValue
            // 
            typeValue.Location = new Point(12, 414);
            typeValue.Name = "typeValue";
            typeValue.Size = new Size(304, 31);
            typeValue.TabIndex = 2;
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new Point(12, 386);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new Size(160, 25);
            typeLabel.TabIndex = 3;
            typeLabel.Text = "ანგარიშის ტიპი";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1114, 781);
            Controls.Add(typeLabel);
            Controls.Add(emailLabel);
            Controls.Add(phoneNumberLabel);
            Controls.Add(typeValue);
            Controls.Add(identityNumberLabel);
            Controls.Add(emailValue);
            Controls.Add(nameLabel);
            Controls.Add(phoneValue);
            Controls.Add(identityNumberValue);
            Controls.Add(nameValue);
            Controls.Add(dataList);
            Controls.Add(headerLabel);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private ListBox dataList;
        private TextBox nameValue;
        private Label nameLabel;
        private TextBox identityNumberValue;
        private Label identityNumberLabel;
        private TextBox phoneValue;
        private Label phoneNumberLabel;
        private TextBox emailValue;
        private Label emailLabel;
        private TextBox typeValue;
        private Label typeLabel;
    }
}

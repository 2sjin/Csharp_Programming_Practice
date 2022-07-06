namespace AnimalShelter {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.CreateCustomerButton = new System.Windows.Forms.Button();
            this.CustomNewPanel = new System.Windows.Forms.Panel();
            this.CustomNewDescription = new System.Windows.Forms.TextBox();
            this.CustomNewAddress = new System.Windows.Forms.TextBox();
            this.CustomNewBirthday = new System.Windows.Forms.TextBox();
            this.CustomNewFirstName = new System.Windows.Forms.TextBox();
            this.CustomNewLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BirthdayLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IsQualifiedLabel = new System.Windows.Forms.Label();
            this.CustomerDetailPanel = new System.Windows.Forms.Panel();
            this.CustomerList = new System.Windows.Forms.ListBox();
            this.CustomNewPanel.SuspendLayout();
            this.CustomerDetailPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateCustomerButton
            // 
            this.CreateCustomerButton.Location = new System.Drawing.Point(299, 349);
            this.CreateCustomerButton.Name = "CreateCustomerButton";
            this.CreateCustomerButton.Size = new System.Drawing.Size(136, 40);
            this.CreateCustomerButton.TabIndex = 5;
            this.CreateCustomerButton.Text = "입양자 생성";
            this.CreateCustomerButton.UseVisualStyleBackColor = true;
            this.CreateCustomerButton.Click += new System.EventHandler(this.CreateCustomerButton_Click);
            // 
            // CustomNewPanel
            // 
            this.CustomNewPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CustomNewPanel.Controls.Add(this.CustomNewDescription);
            this.CustomNewPanel.Controls.Add(this.CustomNewAddress);
            this.CustomNewPanel.Controls.Add(this.CreateCustomerButton);
            this.CustomNewPanel.Controls.Add(this.CustomNewBirthday);
            this.CustomNewPanel.Controls.Add(this.CustomNewFirstName);
            this.CustomNewPanel.Controls.Add(this.CustomNewLastName);
            this.CustomNewPanel.Controls.Add(this.label3);
            this.CustomNewPanel.Controls.Add(this.label7);
            this.CustomNewPanel.Controls.Add(this.label11);
            this.CustomNewPanel.Controls.Add(this.label13);
            this.CustomNewPanel.Controls.Add(this.label15);
            this.CustomNewPanel.Location = new System.Drawing.Point(27, 25);
            this.CustomNewPanel.Name = "CustomNewPanel";
            this.CustomNewPanel.Size = new System.Drawing.Size(462, 404);
            this.CustomNewPanel.TabIndex = 12;
            // 
            // CustomNewDescription
            // 
            this.CustomNewDescription.Location = new System.Drawing.Point(89, 205);
            this.CustomNewDescription.Multiline = true;
            this.CustomNewDescription.Name = "CustomNewDescription";
            this.CustomNewDescription.Size = new System.Drawing.Size(346, 120);
            this.CustomNewDescription.TabIndex = 4;
            // 
            // CustomNewAddress
            // 
            this.CustomNewAddress.Location = new System.Drawing.Point(89, 165);
            this.CustomNewAddress.Name = "CustomNewAddress";
            this.CustomNewAddress.Size = new System.Drawing.Size(346, 27);
            this.CustomNewAddress.TabIndex = 3;
            // 
            // CustomNewBirthday
            // 
            this.CustomNewBirthday.Location = new System.Drawing.Point(89, 103);
            this.CustomNewBirthday.Name = "CustomNewBirthday";
            this.CustomNewBirthday.Size = new System.Drawing.Size(346, 27);
            this.CustomNewBirthday.TabIndex = 2;
            // 
            // CustomNewFirstName
            // 
            this.CustomNewFirstName.Location = new System.Drawing.Point(89, 61);
            this.CustomNewFirstName.Name = "CustomNewFirstName";
            this.CustomNewFirstName.Size = new System.Drawing.Size(346, 27);
            this.CustomNewFirstName.TabIndex = 1;
            // 
            // CustomNewLastName
            // 
            this.CustomNewLastName.Location = new System.Drawing.Point(89, 24);
            this.CustomNewLastName.Name = "CustomNewLastName";
            this.CustomNewLastName.Size = new System.Drawing.Size(346, 27);
            this.CustomNewLastName.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "생일:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "설명:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 168);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 20);
            this.label11.TabIndex = 6;
            this.label11.Text = "주소:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(25, 68);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 20);
            this.label13.TabIndex = 4;
            this.label13.Text = "이름:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(25, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(27, 20);
            this.label15.TabIndex = 2;
            this.label15.Text = "성:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "이름:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(76, 27);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(15, 20);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "생일:";
            // 
            // BirthdayLabel
            // 
            this.BirthdayLabel.AutoSize = true;
            this.BirthdayLabel.Location = new System.Drawing.Point(76, 69);
            this.BirthdayLabel.Name = "BirthdayLabel";
            this.BirthdayLabel.Size = new System.Drawing.Size(15, 20);
            this.BirthdayLabel.TabIndex = 5;
            this.BirthdayLabel.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "주소:";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(76, 166);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(15, 20);
            this.AddressLabel.TabIndex = 7;
            this.AddressLabel.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 20);
            this.label10.TabIndex = 8;
            this.label10.Text = "설명:";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(76, 208);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(15, 20);
            this.DescriptionLabel.TabIndex = 9;
            this.DescriptionLabel.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "분양가능여부: ";
            // 
            // IsQualifiedLabel
            // 
            this.IsQualifiedLabel.AutoSize = true;
            this.IsQualifiedLabel.Location = new System.Drawing.Point(138, 111);
            this.IsQualifiedLabel.Name = "IsQualifiedLabel";
            this.IsQualifiedLabel.Size = new System.Drawing.Size(15, 20);
            this.IsQualifiedLabel.TabIndex = 11;
            this.IsQualifiedLabel.Text = "-";
            // 
            // CustomerDetailPanel
            // 
            this.CustomerDetailPanel.Controls.Add(this.CustomerList);
            this.CustomerDetailPanel.Controls.Add(this.IsQualifiedLabel);
            this.CustomerDetailPanel.Controls.Add(this.label2);
            this.CustomerDetailPanel.Controls.Add(this.DescriptionLabel);
            this.CustomerDetailPanel.Controls.Add(this.label10);
            this.CustomerDetailPanel.Controls.Add(this.AddressLabel);
            this.CustomerDetailPanel.Controls.Add(this.label8);
            this.CustomerDetailPanel.Controls.Add(this.BirthdayLabel);
            this.CustomerDetailPanel.Controls.Add(this.label6);
            this.CustomerDetailPanel.Controls.Add(this.NameLabel);
            this.CustomerDetailPanel.Controls.Add(this.label4);
            this.CustomerDetailPanel.Location = new System.Drawing.Point(516, 25);
            this.CustomerDetailPanel.Name = "CustomerDetailPanel";
            this.CustomerDetailPanel.Size = new System.Drawing.Size(541, 404);
            this.CustomerDetailPanel.TabIndex = 1;
            // 
            // CustomerList
            // 
            this.CustomerList.FormattingEnabled = true;
            this.CustomerList.ItemHeight = 20;
            this.CustomerList.Location = new System.Drawing.Point(391, 16);
            this.CustomerList.Name = "CustomerList";
            this.CustomerList.Size = new System.Drawing.Size(128, 364);
            this.CustomerList.TabIndex = 13;
            this.CustomerList.SelectedIndexChanged += new System.EventHandler(this.CustomerList_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 455);
            this.Controls.Add(this.CustomNewPanel);
            this.Controls.Add(this.CustomerDetailPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.CustomNewPanel.ResumeLayout(false);
            this.CustomNewPanel.PerformLayout();
            this.CustomerDetailPanel.ResumeLayout(false);
            this.CustomerDetailPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button CreateCustomerButton;
        private Panel CustomNewPanel;
        private Label label3;
        private Label label7;
        private Label label11;
        private Label label13;
        private Label label15;
        private TextBox CustomNewDescription;
        private TextBox CustomNewAddress;
        private TextBox CustomNewBirthday;
        private TextBox CustomNewFirstName;
        private TextBox CustomNewLastName;
        private Label label4;
        private Label NameLabel;
        private Label label6;
        private Label BirthdayLabel;
        private Label label8;
        private Label AddressLabel;
        private Label label10;
        private Label DescriptionLabel;
        private Label label2;
        private Label IsQualifiedLabel;
        private Panel CustomerDetailPanel;
        private ListBox CustomerList;
    }
}
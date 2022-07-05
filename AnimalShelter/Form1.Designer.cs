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
            this.CustomerDetailPanel = new System.Windows.Forms.Panel();
            this.IsQualifiedLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BirthdayLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CustomerDetailPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateCustomerButton
            // 
            this.CreateCustomerButton.Location = new System.Drawing.Point(22, 21);
            this.CreateCustomerButton.Name = "CreateCustomerButton";
            this.CreateCustomerButton.Size = new System.Drawing.Size(136, 57);
            this.CreateCustomerButton.TabIndex = 0;
            this.CreateCustomerButton.Text = "입양자 생성";
            this.CreateCustomerButton.UseVisualStyleBackColor = true;
            this.CreateCustomerButton.Click += new System.EventHandler(this.CreateCustomerButton_Click);
            // 
            // CustomerDetailPanel
            // 
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
            this.CustomerDetailPanel.Location = new System.Drawing.Point(194, 21);
            this.CustomerDetailPanel.Name = "CustomerDetailPanel";
            this.CustomerDetailPanel.Size = new System.Drawing.Size(462, 260);
            this.CustomerDetailPanel.TabIndex = 1;
            // 
            // IsQualifiedLabel
            // 
            this.IsQualifiedLabel.AutoSize = true;
            this.IsQualifiedLabel.Location = new System.Drawing.Point(108, 110);
            this.IsQualifiedLabel.Name = "IsQualifiedLabel";
            this.IsQualifiedLabel.Size = new System.Drawing.Size(15, 20);
            this.IsQualifiedLabel.TabIndex = 11;
            this.IsQualifiedLabel.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "입양가능: ";
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 20);
            this.label10.TabIndex = 8;
            this.label10.Text = "설명:";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(76, 168);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(15, 20);
            this.AddressLabel.TabIndex = 7;
            this.AddressLabel.Text = "-";
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
            // BirthdayLabel
            // 
            this.BirthdayLabel.AutoSize = true;
            this.BirthdayLabel.Location = new System.Drawing.Point(76, 68);
            this.BirthdayLabel.Name = "BirthdayLabel";
            this.BirthdayLabel.Size = new System.Drawing.Size(15, 20);
            this.BirthdayLabel.TabIndex = 5;
            this.BirthdayLabel.Text = "-";
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
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(76, 27);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(15, 20);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "-";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 314);
            this.Controls.Add(this.CustomerDetailPanel);
            this.Controls.Add(this.CreateCustomerButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.CustomerDetailPanel.ResumeLayout(false);
            this.CustomerDetailPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button CreateCustomerButton;
        private Panel CustomerDetailPanel;
        private Label DescriptionLabel;
        private Label label10;
        private Label AddressLabel;
        private Label label8;
        private Label BirthdayLabel;
        private Label label6;
        private Label NameLabel;
        private Label label4;
        private Label IsQualifiedLabel;
        private Label label2;
    }
}
namespace HelloCSharpWin
{
    partial class Calculator
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
            this.NumButton1 = new System.Windows.Forms.Button();
            this.NumButton2 = new System.Windows.Forms.Button();
            this.NumScreen = new System.Windows.Forms.Label();
            this.MinusButton = new System.Windows.Forms.Button();
            this.NumButton3 = new System.Windows.Forms.Button();
            this.NumButton6 = new System.Windows.Forms.Button();
            this.NumButton5 = new System.Windows.Forms.Button();
            this.NumButton4 = new System.Windows.Forms.Button();
            this.NumButton9 = new System.Windows.Forms.Button();
            this.NumButton8 = new System.Windows.Forms.Button();
            this.NumButton7 = new System.Windows.Forms.Button();
            this.NumButton0 = new System.Windows.Forms.Button();
            this.PlusButton = new System.Windows.Forms.Button();
            this.MultiButton = new System.Windows.Forms.Button();
            this.DivButton = new System.Windows.Forms.Button();
            this.EqualButton = new System.Windows.Forms.Button();
            this.AllClearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NumButton1
            // 
            this.NumButton1.Location = new System.Drawing.Point(27, 228);
            this.NumButton1.Name = "NumButton1";
            this.NumButton1.Size = new System.Drawing.Size(57, 57);
            this.NumButton1.TabIndex = 5;
            this.NumButton1.Text = "1";
            this.NumButton1.UseVisualStyleBackColor = true;
            this.NumButton1.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // NumButton2
            // 
            this.NumButton2.Location = new System.Drawing.Point(90, 228);
            this.NumButton2.Name = "NumButton2";
            this.NumButton2.Size = new System.Drawing.Size(57, 57);
            this.NumButton2.TabIndex = 6;
            this.NumButton2.Text = "2";
            this.NumButton2.UseVisualStyleBackColor = true;
            this.NumButton2.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // NumScreen
            // 
            this.NumScreen.BackColor = System.Drawing.SystemColors.Window;
            this.NumScreen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NumScreen.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumScreen.Location = new System.Drawing.Point(27, 30);
            this.NumScreen.Name = "NumScreen";
            this.NumScreen.Size = new System.Drawing.Size(246, 52);
            this.NumScreen.TabIndex = 7;
            this.NumScreen.Text = "0";
            this.NumScreen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MinusButton
            // 
            this.MinusButton.Location = new System.Drawing.Point(216, 228);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(57, 57);
            this.MinusButton.TabIndex = 8;
            this.MinusButton.Text = "-";
            this.MinusButton.UseVisualStyleBackColor = true;
            this.MinusButton.Click += new System.EventHandler(this.OperatorButton_Click);
            // 
            // NumButton3
            // 
            this.NumButton3.Location = new System.Drawing.Point(153, 228);
            this.NumButton3.Name = "NumButton3";
            this.NumButton3.Size = new System.Drawing.Size(57, 57);
            this.NumButton3.TabIndex = 9;
            this.NumButton3.Text = "3";
            this.NumButton3.UseVisualStyleBackColor = true;
            this.NumButton3.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // NumButton6
            // 
            this.NumButton6.Location = new System.Drawing.Point(153, 165);
            this.NumButton6.Name = "NumButton6";
            this.NumButton6.Size = new System.Drawing.Size(57, 57);
            this.NumButton6.TabIndex = 12;
            this.NumButton6.Text = "6";
            this.NumButton6.UseVisualStyleBackColor = true;
            this.NumButton6.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // NumButton5
            // 
            this.NumButton5.Location = new System.Drawing.Point(90, 165);
            this.NumButton5.Name = "NumButton5";
            this.NumButton5.Size = new System.Drawing.Size(57, 57);
            this.NumButton5.TabIndex = 11;
            this.NumButton5.Text = "5";
            this.NumButton5.UseVisualStyleBackColor = true;
            this.NumButton5.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // NumButton4
            // 
            this.NumButton4.Location = new System.Drawing.Point(26, 165);
            this.NumButton4.Name = "NumButton4";
            this.NumButton4.Size = new System.Drawing.Size(57, 57);
            this.NumButton4.TabIndex = 10;
            this.NumButton4.Text = "4";
            this.NumButton4.UseVisualStyleBackColor = true;
            this.NumButton4.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // NumButton9
            // 
            this.NumButton9.Location = new System.Drawing.Point(153, 102);
            this.NumButton9.Name = "NumButton9";
            this.NumButton9.Size = new System.Drawing.Size(57, 57);
            this.NumButton9.TabIndex = 15;
            this.NumButton9.Text = "9";
            this.NumButton9.UseVisualStyleBackColor = true;
            this.NumButton9.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // NumButton8
            // 
            this.NumButton8.Location = new System.Drawing.Point(90, 102);
            this.NumButton8.Name = "NumButton8";
            this.NumButton8.Size = new System.Drawing.Size(57, 57);
            this.NumButton8.TabIndex = 14;
            this.NumButton8.Text = "8";
            this.NumButton8.UseVisualStyleBackColor = true;
            this.NumButton8.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // NumButton7
            // 
            this.NumButton7.Location = new System.Drawing.Point(26, 102);
            this.NumButton7.Name = "NumButton7";
            this.NumButton7.Size = new System.Drawing.Size(57, 57);
            this.NumButton7.TabIndex = 13;
            this.NumButton7.Text = "7";
            this.NumButton7.UseVisualStyleBackColor = true;
            this.NumButton7.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // NumButton0
            // 
            this.NumButton0.Location = new System.Drawing.Point(90, 291);
            this.NumButton0.Name = "NumButton0";
            this.NumButton0.Size = new System.Drawing.Size(57, 57);
            this.NumButton0.TabIndex = 16;
            this.NumButton0.Text = "0";
            this.NumButton0.UseVisualStyleBackColor = true;
            this.NumButton0.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // PlusButton
            // 
            this.PlusButton.Location = new System.Drawing.Point(216, 291);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(57, 57);
            this.PlusButton.TabIndex = 17;
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = true;
            this.PlusButton.Click += new System.EventHandler(this.OperatorButton_Click);
            // 
            // MultiButton
            // 
            this.MultiButton.Location = new System.Drawing.Point(216, 165);
            this.MultiButton.Name = "MultiButton";
            this.MultiButton.Size = new System.Drawing.Size(57, 57);
            this.MultiButton.TabIndex = 18;
            this.MultiButton.Text = "*";
            this.MultiButton.UseVisualStyleBackColor = true;
            this.MultiButton.Click += new System.EventHandler(this.OperatorButton_Click);
            // 
            // DivButton
            // 
            this.DivButton.Location = new System.Drawing.Point(216, 102);
            this.DivButton.Name = "DivButton";
            this.DivButton.Size = new System.Drawing.Size(57, 57);
            this.DivButton.TabIndex = 19;
            this.DivButton.Text = "/";
            this.DivButton.UseVisualStyleBackColor = true;
            this.DivButton.Click += new System.EventHandler(this.OperatorButton_Click);
            // 
            // EqualButton
            // 
            this.EqualButton.Location = new System.Drawing.Point(153, 291);
            this.EqualButton.Name = "EqualButton";
            this.EqualButton.Size = new System.Drawing.Size(57, 57);
            this.EqualButton.TabIndex = 20;
            this.EqualButton.Text = "=";
            this.EqualButton.UseVisualStyleBackColor = true;
            this.EqualButton.Click += new System.EventHandler(this.OperatorButton_Click);
            // 
            // AllClearButton
            // 
            this.AllClearButton.Location = new System.Drawing.Point(27, 291);
            this.AllClearButton.Name = "AllClearButton";
            this.AllClearButton.Size = new System.Drawing.Size(57, 57);
            this.AllClearButton.TabIndex = 21;
            this.AllClearButton.Text = "AC";
            this.AllClearButton.UseVisualStyleBackColor = true;
            this.AllClearButton.Click += new System.EventHandler(this.AllClearButton_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 386);
            this.Controls.Add(this.AllClearButton);
            this.Controls.Add(this.EqualButton);
            this.Controls.Add(this.DivButton);
            this.Controls.Add(this.MultiButton);
            this.Controls.Add(this.PlusButton);
            this.Controls.Add(this.NumButton0);
            this.Controls.Add(this.NumButton9);
            this.Controls.Add(this.NumButton8);
            this.Controls.Add(this.NumButton7);
            this.Controls.Add(this.NumButton6);
            this.Controls.Add(this.NumButton5);
            this.Controls.Add(this.NumButton4);
            this.Controls.Add(this.NumButton3);
            this.Controls.Add(this.MinusButton);
            this.Controls.Add(this.NumScreen);
            this.Controls.Add(this.NumButton2);
            this.Controls.Add(this.NumButton1);
            this.Name = "Calculator";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }
        #endregion
        private Button NumButton1;
        private Button NumButton2;
        private Label NumScreen;
        private Button MinusButton;
        private Button NumButton3;
        private Button NumButton6;
        private Button NumButton5;
        private Button NumButton4;
        private Button NumButton9;
        private Button NumButton8;
        private Button NumButton7;
        private Button NumButton0;
        private Button PlusButton;
        private Button MultiButton;
        private Button DivButton;
        private Button EqualButton;
        private Button AllClearButton;
    }
}

    

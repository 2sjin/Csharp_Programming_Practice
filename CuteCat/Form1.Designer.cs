namespace CuteCat {
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
            this.components = new System.ComponentModel.Container();
            this.CatScreen = new System.Windows.Forms.Label();
            this.PlayButton = new System.Windows.Forms.Button();
            this.FeedButton = new System.Windows.Forms.Button();
            this.CatTimer = new System.Windows.Forms.Timer(this.components);
            this.HappinessBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // CatScreen
            // 
            this.CatScreen.BackColor = System.Drawing.SystemColors.Window;
            this.CatScreen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CatScreen.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CatScreen.Location = new System.Drawing.Point(12, 9);
            this.CatScreen.Name = "CatScreen";
            this.CatScreen.Size = new System.Drawing.Size(607, 69);
            this.CatScreen.TabIndex = 0;
            this.CatScreen.Text = "label1";
            this.CatScreen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PlayButton
            // 
            this.PlayButton.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayButton.Location = new System.Drawing.Point(183, 171);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(112, 64);
            this.PlayButton.TabIndex = 1;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // FeedButton
            // 
            this.FeedButton.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FeedButton.Location = new System.Drawing.Point(316, 171);
            this.FeedButton.Name = "FeedButton";
            this.FeedButton.Size = new System.Drawing.Size(112, 64);
            this.FeedButton.TabIndex = 1;
            this.FeedButton.Text = "Feed";
            this.FeedButton.UseVisualStyleBackColor = true;
            this.FeedButton.Click += new System.EventHandler(this.FeedButton_Click);
            // 
            // CatTimer
            // 
            this.CatTimer.Enabled = true;
            this.CatTimer.Interval = 500;
            this.CatTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // HappinessBar
            // 
            this.HappinessBar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.HappinessBar.Location = new System.Drawing.Point(12, 95);
            this.HappinessBar.Name = "HappinessBar";
            this.HappinessBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HappinessBar.Size = new System.Drawing.Size(607, 29);
            this.HappinessBar.TabIndex = 2;
            this.HappinessBar.Value = 50;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 259);
            this.Controls.Add(this.HappinessBar);
            this.Controls.Add(this.FeedButton);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.CatScreen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Label CatScreen;
        private Button PlayButton;
        private Button FeedButton;
        private System.Windows.Forms.Timer CatTimer;
        private ProgressBar HappinessBar;
    }
}
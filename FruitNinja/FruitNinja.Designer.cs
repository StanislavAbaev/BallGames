namespace FruitNinja
{
    partial class FruitNinja
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            scoreLabel = new Label();
            bananaBonusTimer = new System.Windows.Forms.Timer(components);
            secondsRemainingLabel = new Label();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 1500;
            timer1.Tick += timer1_Tick;
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            scoreLabel.ForeColor = Color.Red;
            scoreLabel.Location = new Point(12, 9);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(43, 50);
            scoreLabel.TabIndex = 0;
            scoreLabel.Text = "0";
            // 
            // bananaBonusTimer
            // 
            bananaBonusTimer.Interval = 1000;
            bananaBonusTimer.Tick += bananaBonusTimer_Tick;
            // 
            // secondsRemainingLabel
            // 
            secondsRemainingLabel.AutoSize = true;
            secondsRemainingLabel.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            secondsRemainingLabel.Location = new Point(138, 9);
            secondsRemainingLabel.Name = "secondsRemainingLabel";
            secondsRemainingLabel.Size = new Size(43, 50);
            secondsRemainingLabel.TabIndex = 1;
            secondsRemainingLabel.Text = "0";
            // 
            // FruitNinja
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1123, 668);
            Controls.Add(secondsRemainingLabel);
            Controls.Add(scoreLabel);
            Name = "FruitNinja";
            Text = "Form1";
            Load += FruitNinja_Load;
            MouseMove += FruitNinja_MouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label scoreLabel;
        private System.Windows.Forms.Timer bananaBonusTimer;
        private Label secondsRemainingLabel;
    }
}
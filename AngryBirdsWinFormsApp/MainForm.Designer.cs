namespace AngryBirdsWinFormsApp
{
    partial class MainForm
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
            scoreLabel = new Label();
            SuspendLayout();
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            scoreLabel.Location = new Point(20, 22);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(43, 50);
            scoreLabel.TabIndex = 0;
            
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1225, 678);
            Controls.Add(scoreLabel);
            Name = "Form1";
            Text = "Form1";
            Shown += Form1_Shown;
            MouseDown += Form1_MouseDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label scoreLabel;
    }
}
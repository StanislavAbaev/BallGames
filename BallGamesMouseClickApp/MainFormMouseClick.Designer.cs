namespace BallGamesMouseClickApp
{
    partial class MainFormMouseClick
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
            startButton = new Button();
            scoreLabel = new Label();
            clearFieldButton = new Button();
            SuspendLayout();
            // 
            // startButton
            // 
            startButton.Location = new Point(771, 38);
            startButton.Name = "startButton";
            startButton.Size = new Size(182, 46);
            startButton.TabIndex = 0;
            startButton.Text = "Начать игру";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += button1_Click;
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Location = new Point(12, 45);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(66, 32);
            scoreLabel.TabIndex = 1;
            scoreLabel.Text = "Счёт";
            // 
            // clearFieldButton
            // 
            clearFieldButton.Location = new Point(771, 90);
            clearFieldButton.Name = "clearFieldButton";
            clearFieldButton.Size = new Size(182, 46);
            clearFieldButton.TabIndex = 2;
            clearFieldButton.Text = "Очистить";
            clearFieldButton.UseVisualStyleBackColor = true;
            clearFieldButton.Click += clearFieldButton_Click;
            // 
            // MainFormMouseClick
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 559);
            Controls.Add(clearFieldButton);
            Controls.Add(scoreLabel);
            Controls.Add(startButton);
            Name = "MainFormMouseClick";
            Text = "Form1";
            MouseDown += MainFormMouseClick_MouseDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button startButton;
        private Label scoreLabel;
        private Button clearFieldButton;
    }
}
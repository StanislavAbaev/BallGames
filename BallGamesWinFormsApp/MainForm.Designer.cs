namespace BallGamesWinFormsApp
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
            stopBalls = new Button();
            createBalls = new Button();
            scoreLabel = new Label();
            label1 = new Label();
            resetField = new Button();
            SuspendLayout();
            // 
            // stopBalls
            // 
            stopBalls.Location = new Point(650, 7);
            stopBalls.Name = "stopBalls";
            stopBalls.Size = new Size(142, 23);
            stopBalls.TabIndex = 2;
            stopBalls.Text = "Остановить";
            stopBalls.UseVisualStyleBackColor = true;
            stopBalls.Click += stopBalls_Click;
            // 
            // createBalls
            // 
            createBalls.Location = new Point(503, 7);
            createBalls.Name = "createBalls";
            createBalls.Size = new Size(140, 23);
            createBalls.TabIndex = 3;
            createBalls.Text = "Создать";
            createBalls.UseVisualStyleBackColor = true;
            createBalls.Click += createBalls_Click;
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Location = new Point(49, 11);
            scoreLabel.Margin = new Padding(2, 0, 2, 0);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(0, 15);
            scoreLabel.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 11);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 5;
            label1.Text = "Счёт";
            // 
            // resetField
            // 
            resetField.Location = new Point(650, 34);
            resetField.Margin = new Padding(2, 1, 2, 1);
            resetField.Name = "resetField";
            resetField.Size = new Size(142, 22);
            resetField.TabIndex = 6;
            resetField.Text = "Очистить холст";
            resetField.UseVisualStyleBackColor = true;
            resetField.Click += resetField_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resetField);
            Controls.Add(label1);
            Controls.Add(scoreLabel);
            Controls.Add(createBalls);
            Controls.Add(stopBalls);
            Name = "MainForm";
            Text = "Form1";
            MouseDown += MainForm_MouseDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button stopBalls;
        private Button createBalls;
        private Label scoreLabel;
        private Label label1;
        private Button resetField;
    }
}
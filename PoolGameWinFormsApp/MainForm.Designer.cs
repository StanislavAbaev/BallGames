namespace PoolGameWinFormsApp
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
            redTopLabel = new Label();
            redRightLabel = new Label();
            redDownLabel = new Label();
            redLeftLabel = new Label();
            blueLeftLabel = new Label();
            blueTopLabel = new Label();
            blueRightLabel = new Label();
            blueDownLabel = new Label();
            SuspendLayout();
            // 
            // redTopLabel
            // 
            redTopLabel.AutoSize = true;
            redTopLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            redTopLabel.ForeColor = Color.Red;
            redTopLabel.Location = new Point(381, 9);
            redTopLabel.Name = "redTopLabel";
            redTopLabel.Size = new Size(19, 21);
            redTopLabel.TabIndex = 0;
            redTopLabel.Text = "0";
            // 
            // redRightLabel
            // 
            redRightLabel.AutoSize = true;
            redRightLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            redRightLabel.ForeColor = Color.Red;
            redRightLabel.Location = new Point(769, 218);
            redRightLabel.Name = "redRightLabel";
            redRightLabel.Size = new Size(19, 21);
            redRightLabel.TabIndex = 1;
            redRightLabel.Text = "0";
            // 
            // redDownLabel
            // 
            redDownLabel.AutoSize = true;
            redDownLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            redDownLabel.ForeColor = Color.Red;
            redDownLabel.Location = new Point(381, 426);
            redDownLabel.Name = "redDownLabel";
            redDownLabel.Size = new Size(19, 21);
            redDownLabel.TabIndex = 2;
            redDownLabel.Text = "0";
            // 
            // redLeftLabel
            // 
            redLeftLabel.AutoSize = true;
            redLeftLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            redLeftLabel.ForeColor = Color.Red;
            redLeftLabel.Location = new Point(12, 218);
            redLeftLabel.Name = "redLeftLabel";
            redLeftLabel.Size = new Size(19, 21);
            redLeftLabel.TabIndex = 3;
            redLeftLabel.Text = "0";
            // 
            // blueLeftLabel
            // 
            blueLeftLabel.AutoSize = true;
            blueLeftLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            blueLeftLabel.ForeColor = Color.Blue;
            blueLeftLabel.Location = new Point(12, 197);
            blueLeftLabel.Name = "blueLeftLabel";
            blueLeftLabel.Size = new Size(19, 21);
            blueLeftLabel.TabIndex = 4;
            blueLeftLabel.Text = "0";
            // 
            // blueTopLabel
            // 
            blueTopLabel.AutoSize = true;
            blueTopLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            blueTopLabel.ForeColor = Color.Blue;
            blueTopLabel.Location = new Point(406, 9);
            blueTopLabel.Name = "blueTopLabel";
            blueTopLabel.Size = new Size(19, 21);
            blueTopLabel.TabIndex = 5;
            blueTopLabel.Text = "0";
            // 
            // blueRightLabel
            // 
            blueRightLabel.AutoSize = true;
            blueRightLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            blueRightLabel.ForeColor = Color.Blue;
            blueRightLabel.Location = new Point(769, 197);
            blueRightLabel.Name = "blueRightLabel";
            blueRightLabel.Size = new Size(19, 21);
            blueRightLabel.TabIndex = 6;
            blueRightLabel.Text = "0";
            // 
            // blueDownLabel
            // 
            blueDownLabel.AutoSize = true;
            blueDownLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            blueDownLabel.ForeColor = Color.Blue;
            blueDownLabel.Location = new Point(406, 426);
            blueDownLabel.Name = "blueDownLabel";
            blueDownLabel.Size = new Size(19, 21);
            blueDownLabel.TabIndex = 7;
            blueDownLabel.Text = "0";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(blueDownLabel);
            Controls.Add(blueRightLabel);
            Controls.Add(blueTopLabel);
            Controls.Add(blueLeftLabel);
            Controls.Add(redLeftLabel);
            Controls.Add(redDownLabel);
            Controls.Add(redRightLabel);
            Controls.Add(redTopLabel);
            Name = "MainForm";
            Text = "Form1";
            Load += Form1_Load;
            MouseDown += MainForm_MouseDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label redTopLabel;
        private Label redRightLabel;
        private Label redDownLabel;
        private Label redLeftLabel;
        private Label blueLeftLabel;
        private Label blueTopLabel;
        private Label blueRightLabel;
        private Label blueDownLabel;
    }
}
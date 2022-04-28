namespace MathQuiz
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.timeLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timeLabel
            // 
            this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeLabel.Location = new System.Drawing.Point(576, 60);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(198, 42);
            this.timeLabel.TabIndex = 0;
            this.timeLabel.Text = "label1";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(341, 556);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(200, 70);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start the Quiz";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 694);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.timeLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Math Quiz";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Button startButton;
    }
}


namespace Ascension
{
    partial class StartPage
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
            StartButton = new Button();
            SuspendLayout();
            // 
            // StartButton
            // 
            StartButton.Location = new Point(383, 843);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(284, 69);
            StartButton.TabIndex = 0;
            StartButton.Text = "Click to Start!";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // StartPage
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.logo;
            ClientSize = new Size(1025, 1015);
            Controls.Add(StartButton);
            Name = "StartPage";
            Text = "Start Page";
            ResumeLayout(false);
        }

        #endregion

        private Button StartButton;
    }
}

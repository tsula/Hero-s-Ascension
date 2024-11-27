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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartPage));
            StartButton = new Button();
            SuspendLayout();
            // 
            // StartButton
            // 
            StartButton.Anchor = AnchorStyles.None;
            StartButton.BackColor = Color.Black;
            StartButton.BackgroundImage = (Image)resources.GetObject("StartButton.BackgroundImage");
            StartButton.BackgroundImageLayout = ImageLayout.Zoom;
            StartButton.Location = new Point(336, 271);
            StartButton.Margin = new Padding(0);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(143, 46);
            StartButton.TabIndex = 0;
            StartButton.UseVisualStyleBackColor = false;
            StartButton.Click += StartButton_Click;
            // 
            // StartPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.logo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(802, 456);
            Controls.Add(StartButton);
            Margin = new Padding(1);
            Name = "StartPage";
            Text = "Start Page";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion

        private Button StartButton;
    }
}

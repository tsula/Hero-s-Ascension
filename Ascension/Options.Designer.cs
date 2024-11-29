namespace Ascension
{
    partial class Options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            ReturnBtn = new Button();
            SuspendLayout();
            // 
            // ReturnBtn
            // 
            ReturnBtn.Anchor = AnchorStyles.None;
            ReturnBtn.BackgroundImage = (Image)resources.GetObject("ReturnBtn.BackgroundImage");
            ReturnBtn.FlatAppearance.BorderSize = 0;
            ReturnBtn.FlatStyle = FlatStyle.Flat;
            ReturnBtn.Location = new Point(352, 275);
            ReturnBtn.Margin = new Padding(2, 1, 2, 1);
            ReturnBtn.Name = "ReturnBtn";
            ReturnBtn.Size = new Size(158, 32);
            ReturnBtn.TabIndex = 0;
            ReturnBtn.Text = "< Go Back";
            ReturnBtn.UseVisualStyleBackColor = true;
            ReturnBtn.Click += ReturnBtn_Click;
            // 
            // Options
            // 
            AutoScaleDimensions = new SizeF(14F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(802, 456);
            Controls.Add(ReturnBtn);
            Font = new Font("Matura MT Script Capitals", 12F, FontStyle.Bold);
            ForeColor = Color.LightYellow;
            Margin = new Padding(2, 1, 2, 1);
            Name = "Options";
            Text = "Options";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion

        private Button ReturnBtn;
    }
}
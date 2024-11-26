namespace Ascension
{
    partial class Credits
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
            ReturnBtn = new Button();
            SuspendLayout();
            // 
            // ReturnBtn
            // 
            ReturnBtn.Location = new Point(410, 624);
            ReturnBtn.Name = "ReturnBtn";
            ReturnBtn.Size = new Size(225, 69);
            ReturnBtn.TabIndex = 0;
            ReturnBtn.Text = "Go Back";
            ReturnBtn.UseVisualStyleBackColor = true;
            ReturnBtn.Click += ReturnBtn_Click;
            // 
            // Credits
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.credits;
            ClientSize = new Size(1024, 1020);
            Controls.Add(ReturnBtn);
            Name = "Credits";
            Text = "Credits";
            ResumeLayout(false);
        }

        #endregion

        private Button ReturnBtn;
    }
}
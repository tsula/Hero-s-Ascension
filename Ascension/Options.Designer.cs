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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // ReturnBtn
            // 
            ReturnBtn.Anchor = AnchorStyles.None;
            ReturnBtn.BackgroundImage = (Image)resources.GetObject("ReturnBtn.BackgroundImage");
            ReturnBtn.FlatAppearance.BorderSize = 0;
            ReturnBtn.FlatStyle = FlatStyle.Flat;
            ReturnBtn.Location = new Point(352, 386);
            ReturnBtn.Margin = new Padding(2, 1, 2, 1);
            ReturnBtn.Name = "ReturnBtn";
            ReturnBtn.Size = new Size(158, 32);
            ReturnBtn.TabIndex = 0;
            ReturnBtn.Text = "< Go Back";
            ReturnBtn.UseVisualStyleBackColor = true;
            ReturnBtn.Click += ReturnBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Maroon;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(288, 211);
            label1.Name = "label1";
            label1.Size = new Size(61, 22);
            label1.TabIndex = 1;
            label1.Text = "Move";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.Location = new Point(545, 211);
            label2.Name = "label2";
            label2.Size = new Size(62, 23);
            label2.TabIndex = 2;
            label2.Text = "WASD";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.Location = new Point(397, 211);
            label3.Name = "label3";
            label3.Size = new Size(111, 23);
            label3.TabIndex = 3;
            label3.Text = "Arrow Keys";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Image = (Image)resources.GetObject("label4.Image");
            label4.Location = new Point(288, 245);
            label4.Name = "label4";
            label4.Size = new Size(70, 22);
            label4.TabIndex = 4;
            label4.Text = "Attack";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Image = (Image)resources.GetObject("label5.Image");
            label5.Location = new Point(397, 245);
            label5.Name = "label5";
            label5.Size = new Size(114, 22);
            label5.TabIndex = 5;
            label5.Text = "Attack Kay";
            // 
            // Options
            // 
            AutoScaleDimensions = new SizeF(14F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(802, 456);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ReturnBtn);
            Font = new Font("Matura MT Script Capitals", 12F, FontStyle.Bold);
            ForeColor = Color.Maroon;
            Margin = new Padding(2, 1, 2, 1);
            Name = "Options";
            Text = "Options";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ReturnBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
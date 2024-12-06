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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Credits));
            ReturnBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // ReturnBtn
            // 
            ReturnBtn.BackgroundImage = (Image)resources.GetObject("ReturnBtn.BackgroundImage");
            ReturnBtn.BackgroundImageLayout = ImageLayout.Stretch;
            ReturnBtn.FlatAppearance.BorderSize = 0;
            ReturnBtn.FlatStyle = FlatStyle.Flat;
            ReturnBtn.ForeColor = Color.LightYellow;
            ReturnBtn.Location = new Point(229, 142);
            ReturnBtn.Margin = new Padding(2, 1, 2, 1);
            ReturnBtn.Name = "ReturnBtn";
            ReturnBtn.Size = new Size(305, 95);
            ReturnBtn.TabIndex = 0;
            ReturnBtn.Text = "Go Back";
            ReturnBtn.UseVisualStyleBackColor = true;
            ReturnBtn.Click += ReturnBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Matura MT Script Capitals", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightSalmon;
            label1.Location = new Point(953, 57);
            label1.Name = "label1";
            label1.Size = new Size(699, 75);
            label1.TabIndex = 1;
            label1.Text = "CSC 317 - Final Project";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Matura MT Script Capitals", 12F, FontStyle.Bold);
            label2.ForeColor = Color.LightSalmon;
            label2.Location = new Point(1037, 133);
            label2.Name = "label2";
            label2.Size = new Size(517, 64);
            label2.TabIndex = 2;
            label2.Text = "Boss Fight Brigade";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Matura MT Script Capitals", 12F, FontStyle.Bold);
            label3.ForeColor = Color.LightSalmon;
            label3.Location = new Point(1180, 262);
            label3.Name = "label3";
            label3.Size = new Size(656, 64);
            label3.TabIndex = 3;
            label3.Text = "Team Leader: Tisa Willis";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Matura MT Script Capitals", 12F, FontStyle.Bold);
            label4.ForeColor = Color.LightSalmon;
            label4.Location = new Point(1180, 348);
            label4.Name = "label4";
            label4.Size = new Size(845, 64);
            label4.TabIndex = 4;
            label4.Text = "Lead Designer: Pratima Rajbanshi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Matura MT Script Capitals", 12F, FontStyle.Bold);
            label5.ForeColor = Color.LightSalmon;
            label5.Location = new Point(1180, 430);
            label5.Name = "label5";
            label5.Size = new Size(802, 64);
            label5.TabIndex = 5;
            label5.Text = "Lead Developer: Jacob Rafferty";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Matura MT Script Capitals", 12F, FontStyle.Bold);
            label6.ForeColor = Color.LightSalmon;
            label6.Location = new Point(1180, 514);
            label6.Name = "label6";
            label6.Size = new Size(664, 64);
            label6.TabIndex = 6;
            label6.Text = "Lead Tester: Jeep Dewitt";
            // 
            // Credits
            // 
            AutoScaleDimensions = new SizeF(39F, 64F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1883, 1383);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ReturnBtn);
            Font = new Font("Matura MT Script Capitals", 12F, FontStyle.Bold);
            Margin = new Padding(2, 1, 2, 1);
            Name = "Credits";
            Text = "Credits";
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
        private Label label6;
    }
}
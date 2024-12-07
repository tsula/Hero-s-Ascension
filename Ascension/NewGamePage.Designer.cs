namespace Ascension
{
    partial class NewGamePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewGamePage));
            ReturnBtn = new Button();
            CreateBtn = new Button();
            CreateUserNameLbl = new Label();
            CreatePasswordLbl = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            ClassLbl = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // ReturnBtn
            // 
            ReturnBtn.Anchor = AnchorStyles.None;
            ReturnBtn.BackgroundImage = (Image)resources.GetObject("ReturnBtn.BackgroundImage");
            ReturnBtn.FlatAppearance.BorderSize = 0;
            ReturnBtn.FlatStyle = FlatStyle.Flat;
            ReturnBtn.Font = new Font("Matura MT Script Capitals", 12F, FontStyle.Bold);
            ReturnBtn.ForeColor = Color.Maroon;
            ReturnBtn.Location = new Point(289, 391);
            ReturnBtn.Margin = new Padding(1);
            ReturnBtn.Name = "ReturnBtn";
            ReturnBtn.Size = new Size(124, 31);
            ReturnBtn.TabIndex = 0;
            ReturnBtn.Text = "< Go Back";
            ReturnBtn.UseVisualStyleBackColor = true;
            ReturnBtn.Click += ReturnBtn_Click;
            // 
            // CreateBtn
            // 
            CreateBtn.Anchor = AnchorStyles.None;
            CreateBtn.BackgroundImage = (Image)resources.GetObject("CreateBtn.BackgroundImage");
            CreateBtn.FlatAppearance.BorderSize = 0;
            CreateBtn.FlatStyle = FlatStyle.Flat;
            CreateBtn.Font = new Font("Matura MT Script Capitals", 12F, FontStyle.Bold);
            CreateBtn.ForeColor = Color.Maroon;
            CreateBtn.Location = new Point(415, 391);
            CreateBtn.Margin = new Padding(1);
            CreateBtn.Name = "CreateBtn";
            CreateBtn.Size = new Size(106, 31);
            CreateBtn.TabIndex = 1;
            CreateBtn.Text = "Create >";
            CreateBtn.UseVisualStyleBackColor = true;
            CreateBtn.Click += CreateBtn_Click;
            // 
            // CreateUserNameLbl
            // 
            CreateUserNameLbl.Anchor = AnchorStyles.None;
            CreateUserNameLbl.AutoSize = true;
            CreateUserNameLbl.BackColor = Color.Transparent;
            CreateUserNameLbl.Font = new Font("Matura MT Script Capitals", 12F, FontStyle.Bold);
            CreateUserNameLbl.ForeColor = Color.Maroon;
            CreateUserNameLbl.Image = (Image)resources.GetObject("CreateUserNameLbl.Image");
            CreateUserNameLbl.Location = new Point(262, 130);
            CreateUserNameLbl.Margin = new Padding(1, 0, 1, 0);
            CreateUserNameLbl.Name = "CreateUserNameLbl";
            CreateUserNameLbl.Size = new Size(92, 22);
            CreateUserNameLbl.TabIndex = 2;
            CreateUserNameLbl.Text = "Username";
            // 
            // CreatePasswordLbl
            // 
            CreatePasswordLbl.Anchor = AnchorStyles.None;
            CreatePasswordLbl.AutoSize = true;
            CreatePasswordLbl.BackColor = Color.Transparent;
            CreatePasswordLbl.Font = new Font("Matura MT Script Capitals", 12F, FontStyle.Bold);
            CreatePasswordLbl.ForeColor = Color.Maroon;
            CreatePasswordLbl.Image = (Image)resources.GetObject("CreatePasswordLbl.Image");
            CreatePasswordLbl.Location = new Point(262, 160);
            CreatePasswordLbl.Margin = new Padding(1, 0, 1, 0);
            CreatePasswordLbl.Name = "CreatePasswordLbl";
            CreatePasswordLbl.Size = new Size(92, 22);
            CreatePasswordLbl.TabIndex = 3;
            CreatePasswordLbl.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.None;
            txtUsername.Location = new Point(376, 129);
            txtUsername.Margin = new Padding(1);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(108, 23);
            txtUsername.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.Location = new Point(376, 160);
            txtPassword.Margin = new Padding(1);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(108, 23);
            txtPassword.TabIndex = 5;
            // 
            // ClassLbl
            // 
            ClassLbl.Anchor = AnchorStyles.None;
            ClassLbl.AutoSize = true;
            ClassLbl.BackColor = Color.Transparent;
            ClassLbl.Font = new Font("Matura MT Script Capitals", 12F, FontStyle.Bold);
            ClassLbl.ForeColor = Color.Maroon;
            ClassLbl.Image = (Image)resources.GetObject("ClassLbl.Image");
            ClassLbl.Location = new Point(377, 219);
            ClassLbl.Margin = new Padding(1, 0, 1, 0);
            ClassLbl.Name = "ClassLbl";
            ClassLbl.Size = new Size(58, 22);
            ClassLbl.TabIndex = 6;
            ClassLbl.Text = "Class";
            // 
            // radioButton1
            // 
            radioButton1.Anchor = AnchorStyles.None;
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.Transparent;
            radioButton1.BackgroundImage = (Image)resources.GetObject("radioButton1.BackgroundImage");
            radioButton1.Font = new Font("Matura MT Script Capitals", 12F, FontStyle.Bold);
            radioButton1.ForeColor = Color.Maroon;
            radioButton1.Location = new Point(261, 353);
            radioButton1.Margin = new Padding(1);
            radioButton1.Name = "radioButton1";
            radioButton1.Padding = new Padding(5, 0, 0, 0);
            radioButton1.Size = new Size(92, 26);
            radioButton1.TabIndex = 7;
            radioButton1.TabStop = true;
            radioButton1.Text = "Knight";
            radioButton1.UseVisualStyleBackColor = false;
            radioButton1.CheckedChanged += CharacterSelectionChanged;
            radioButton1.Click += CharacterSelectionChanged;
            // 
            // radioButton2
            // 
            radioButton2.Anchor = AnchorStyles.None;
            radioButton2.AutoSize = true;
            radioButton2.BackColor = Color.Transparent;
            radioButton2.BackgroundImage = (Image)resources.GetObject("radioButton2.BackgroundImage");
            radioButton2.Font = new Font("Matura MT Script Capitals", 12F, FontStyle.Bold);
            radioButton2.ForeColor = Color.Maroon;
            radioButton2.Location = new Point(376, 353);
            radioButton2.Margin = new Padding(1);
            radioButton2.Name = "radioButton2";
            radioButton2.Padding = new Padding(5, 0, 0, 0);
            radioButton2.Size = new Size(84, 26);
            radioButton2.TabIndex = 8;
            radioButton2.TabStop = true;
            radioButton2.Text = "Mage";
            radioButton2.UseVisualStyleBackColor = false;
            radioButton2.CheckedChanged += CharacterSelectionChanged;
            radioButton2.Click += CharacterSelectionChanged;
            // 
            // radioButton3
            // 
            radioButton3.Anchor = AnchorStyles.None;
            radioButton3.AutoSize = true;
            radioButton3.BackgroundImage = (Image)resources.GetObject("radioButton3.BackgroundImage");
            radioButton3.Font = new Font("Matura MT Script Capitals", 12F, FontStyle.Bold);
            radioButton3.ForeColor = Color.Maroon;
            radioButton3.Location = new Point(484, 353);
            radioButton3.Margin = new Padding(1);
            radioButton3.Name = "radioButton3";
            radioButton3.Padding = new Padding(5, 0, 0, 0);
            radioButton3.Size = new Size(86, 26);
            radioButton3.TabIndex = 9;
            radioButton3.TabStop = true;
            radioButton3.Text = "Rogue";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += CharacterSelectionChanged;
            radioButton3.Click += CharacterSelectionChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(276, 283);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 57);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(497, 283);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(57, 57);
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.None;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(387, 283);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(57, 57);
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // NewGamePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.newGame;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(802, 456);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(ClassLbl);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(CreatePasswordLbl);
            Controls.Add(CreateUserNameLbl);
            Controls.Add(CreateBtn);
            Controls.Add(ReturnBtn);
            ForeColor = Color.Maroon;
            Margin = new Padding(1);
            Name = "NewGamePage";
            Text = "New Game";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ReturnBtn;
        private Button CreateBtn;
        private Label CreateUserNameLbl;
        private Label CreatePasswordLbl;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label ClassLbl;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}
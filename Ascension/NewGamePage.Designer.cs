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
            SuspendLayout();
            // 
            // ReturnBtn
            // 
            ReturnBtn.Location = new Point(270, 868);
            ReturnBtn.Name = "ReturnBtn";
            ReturnBtn.Size = new Size(225, 69);
            ReturnBtn.TabIndex = 0;
            ReturnBtn.Text = "Go Back";
            ReturnBtn.UseVisualStyleBackColor = true;
            ReturnBtn.Click += ReturnBtn_Click;
            // 
            // CreateBtn
            // 
            CreateBtn.Location = new Point(501, 868);
            CreateBtn.Name = "CreateBtn";
            CreateBtn.Size = new Size(225, 69);
            CreateBtn.TabIndex = 1;
            CreateBtn.Text = "Create";
            CreateBtn.UseVisualStyleBackColor = true;
            CreateBtn.Click += CreateBtn_Click;
            // 
            // CreateUserNameLbl
            // 
            CreateUserNameLbl.AutoSize = true;
            CreateUserNameLbl.Location = new Point(119, 143);
            CreateUserNameLbl.Name = "CreateUserNameLbl";
            CreateUserNameLbl.Size = new Size(180, 48);
            CreateUserNameLbl.TabIndex = 2;
            CreateUserNameLbl.Text = "Username";
            // 
            // CreatePasswordLbl
            // 
            CreatePasswordLbl.AutoSize = true;
            CreatePasswordLbl.Location = new Point(119, 235);
            CreatePasswordLbl.Name = "CreatePasswordLbl";
            CreatePasswordLbl.Size = new Size(168, 48);
            CreatePasswordLbl.TabIndex = 3;
            CreatePasswordLbl.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(366, 136);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(300, 55);
            txtUsername.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(366, 235);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(300, 55);
            txtPassword.TabIndex = 5;
            // 
            // ClassLbl
            // 
            ClassLbl.AutoSize = true;
            ClassLbl.Location = new Point(119, 467);
            ClassLbl.Name = "ClassLbl";
            ClassLbl.Size = new Size(99, 48);
            ClassLbl.TabIndex = 6;
            ClassLbl.Text = "Class";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(366, 467);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(167, 52);
            radioButton1.TabIndex = 7;
            radioButton1.TabStop = true;
            radioButton1.Text = "Knight";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(366, 544);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(154, 52);
            radioButton2.TabIndex = 8;
            radioButton2.TabStop = true;
            radioButton2.Text = "Mage";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(365, 623);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(166, 52);
            radioButton3.TabIndex = 9;
            radioButton3.TabStop = true;
            radioButton3.Text = "Rogue";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // NewGamePage
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.newGame;
            ClientSize = new Size(1025, 1026);
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
            Name = "NewGamePage";
            Text = "New Game";
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
    }
}
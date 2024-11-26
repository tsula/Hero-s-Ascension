namespace Ascension
{
    partial class LoadGamePage
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
            UserlblSignIn = new Label();
            PWlblSignIn = new Label();
            UserSignIn = new TextBox();
            PwSignIn = new TextBox();
            SignInBtn = new Button();
            ReturnBtn = new Button();
            SuspendLayout();
            // 
            // UserlblSignIn
            // 
            UserlblSignIn.AutoSize = true;
            UserlblSignIn.Location = new Point(188, 293);
            UserlblSignIn.Name = "UserlblSignIn";
            UserlblSignIn.Size = new Size(180, 48);
            UserlblSignIn.TabIndex = 0;
            UserlblSignIn.Text = "Username";
            // 
            // PWlblSignIn
            // 
            PWlblSignIn.AutoSize = true;
            PWlblSignIn.Location = new Point(188, 421);
            PWlblSignIn.Name = "PWlblSignIn";
            PWlblSignIn.Size = new Size(168, 48);
            PWlblSignIn.TabIndex = 1;
            PWlblSignIn.Text = "Password";
            // 
            // UserSignIn
            // 
            UserSignIn.Location = new Point(450, 293);
            UserSignIn.Name = "UserSignIn";
            UserSignIn.Size = new Size(300, 55);
            UserSignIn.TabIndex = 2;
            // 
            // PwSignIn
            // 
            PwSignIn.Location = new Point(450, 414);
            PwSignIn.Name = "PwSignIn";
            PwSignIn.Size = new Size(300, 55);
            PwSignIn.TabIndex = 3;
            PwSignIn.UseSystemPasswordChar = true;
            // 
            // SignInBtn
            // 
            SignInBtn.Location = new Point(484, 627);
            SignInBtn.Name = "SignInBtn";
            SignInBtn.Size = new Size(225, 69);
            SignInBtn.TabIndex = 4;
            SignInBtn.Text = "Sign In";
            SignInBtn.UseVisualStyleBackColor = true;
            SignInBtn.Click += SignInBtn_Click;
            // 
            // ReturnBtn
            // 
            ReturnBtn.Location = new Point(253, 627);
            ReturnBtn.Name = "ReturnBtn";
            ReturnBtn.Size = new Size(225, 69);
            ReturnBtn.TabIndex = 5;
            ReturnBtn.Text = "Go Back";
            ReturnBtn.UseVisualStyleBackColor = true;
            ReturnBtn.Click += ReturnBtn_Click;
            // 
            // LoadGamePage
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.loadGame;
            ClientSize = new Size(1019, 1003);
            Controls.Add(ReturnBtn);
            Controls.Add(SignInBtn);
            Controls.Add(PwSignIn);
            Controls.Add(UserSignIn);
            Controls.Add(PWlblSignIn);
            Controls.Add(UserlblSignIn);
            Name = "LoadGamePage";
            Text = "Load Game";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UserlblSignIn;
        private Label PWlblSignIn;
        private TextBox UserSignIn;
        private TextBox PwSignIn;
        private Button SignInBtn;
        private Button ReturnBtn;
    }
}
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadGamePage));
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
            UserlblSignIn.Anchor = AnchorStyles.None;
            UserlblSignIn.AutoSize = true;
            UserlblSignIn.BackColor = Color.Transparent;
            UserlblSignIn.Location = new Point(235, 156);
            UserlblSignIn.Margin = new Padding(2, 0, 2, 0);
            UserlblSignIn.Name = "UserlblSignIn";
            UserlblSignIn.Size = new Size(92, 22);
            UserlblSignIn.TabIndex = 0;
            UserlblSignIn.Text = "Username";
            // 
            // PWlblSignIn
            // 
            PWlblSignIn.Anchor = AnchorStyles.None;
            PWlblSignIn.AutoSize = true;
            PWlblSignIn.BackColor = Color.Transparent;
            PWlblSignIn.Location = new Point(235, 215);
            PWlblSignIn.Margin = new Padding(2, 0, 2, 0);
            PWlblSignIn.Name = "PWlblSignIn";
            PWlblSignIn.Size = new Size(92, 22);
            PWlblSignIn.TabIndex = 1;
            PWlblSignIn.Text = "Password";
            // 
            // UserSignIn
            // 
            UserSignIn.Anchor = AnchorStyles.None;
            UserSignIn.Location = new Point(341, 154);
            UserSignIn.Margin = new Padding(2, 1, 2, 1);
            UserSignIn.Name = "UserSignIn";
            UserSignIn.Size = new Size(212, 29);
            UserSignIn.TabIndex = 2;
            // 
            // PwSignIn
            // 
            PwSignIn.Anchor = AnchorStyles.None;
            PwSignIn.Location = new Point(341, 208);
            PwSignIn.Margin = new Padding(2, 1, 2, 1);
            PwSignIn.Name = "PwSignIn";
            PwSignIn.Size = new Size(212, 29);
            PwSignIn.TabIndex = 3;
            PwSignIn.UseSystemPasswordChar = true;
            // 
            // SignInBtn
            // 
            SignInBtn.Anchor = AnchorStyles.None;
            SignInBtn.BackColor = Color.Transparent;
            SignInBtn.BackgroundImage = (Image)resources.GetObject("SignInBtn.BackgroundImage");
            SignInBtn.FlatAppearance.BorderSize = 0;
            SignInBtn.FlatStyle = FlatStyle.Flat;
            SignInBtn.Location = new Point(395, 307);
            SignInBtn.Margin = new Padding(2, 1, 2, 1);
            SignInBtn.Name = "SignInBtn";
            SignInBtn.Size = new Size(158, 32);
            SignInBtn.TabIndex = 4;
            SignInBtn.Text = "Sign In >";
            SignInBtn.UseVisualStyleBackColor = false;
            SignInBtn.Click += SignInBtn_Click;
            // 
            // ReturnBtn
            // 
            ReturnBtn.Anchor = AnchorStyles.None;
            ReturnBtn.BackColor = Color.Transparent;
            ReturnBtn.BackgroundImage = (Image)resources.GetObject("ReturnBtn.BackgroundImage");
            ReturnBtn.FlatAppearance.BorderSize = 0;
            ReturnBtn.FlatStyle = FlatStyle.Flat;
            ReturnBtn.Location = new Point(235, 307);
            ReturnBtn.Margin = new Padding(2, 1, 2, 1);
            ReturnBtn.Name = "ReturnBtn";
            ReturnBtn.Size = new Size(158, 32);
            ReturnBtn.TabIndex = 5;
            ReturnBtn.Text = "< Go Back";
            ReturnBtn.UseVisualStyleBackColor = false;
            ReturnBtn.Click += ReturnBtn_Click;
            // 
            // LoadGamePage
            // 
            AutoScaleDimensions = new SizeF(14F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(802, 456);
            Controls.Add(ReturnBtn);
            Controls.Add(SignInBtn);
            Controls.Add(PwSignIn);
            Controls.Add(UserSignIn);
            Controls.Add(PWlblSignIn);
            Controls.Add(UserlblSignIn);
            Font = new Font("Matura MT Script Capitals", 12F, FontStyle.Bold);
            ForeColor = Color.LightYellow;
            Margin = new Padding(2, 1, 2, 1);
            Name = "LoadGamePage";
            Text = "Load Game";
            WindowState = FormWindowState.Maximized;
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
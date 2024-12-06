namespace Ascension
{
    partial class GameSelectScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameSelectScreen));
            NewGameButton = new Button();
            LoadGameButton = new Button();
            OptionsButton = new Button();
            CreditsButton = new Button();
            ExitButton = new Button();
            SuspendLayout();
            // 
            // NewGameButton
            // 
            NewGameButton.Anchor = AnchorStyles.None;
            NewGameButton.BackColor = SystemColors.ControlDarkDark;
            NewGameButton.BackgroundImage = (Image)resources.GetObject("NewGameButton.BackgroundImage");
            NewGameButton.BackgroundImageLayout = ImageLayout.Stretch;
            NewGameButton.FlatAppearance.BorderSize = 0;
            NewGameButton.FlatStyle = FlatStyle.Flat;
            NewGameButton.Font = new Font("Matura MT Script Capitals", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NewGameButton.ForeColor = Color.FromArgb(192, 0, 0);
            NewGameButton.Location = new Point(314, 296);
            NewGameButton.Margin = new Padding(1, 1, 1, 1);
            NewGameButton.Name = "NewGameButton";
            NewGameButton.Size = new Size(131, 29);
            NewGameButton.TabIndex = 0;
            NewGameButton.Text = "New Game";
            NewGameButton.UseVisualStyleBackColor = false;
            NewGameButton.Click += NewGameButton_Click;
            // 
            // LoadGameButton
            // 
            LoadGameButton.Anchor = AnchorStyles.None;
            LoadGameButton.BackColor = SystemColors.ControlDarkDark;
            LoadGameButton.BackgroundImage = (Image)resources.GetObject("LoadGameButton.BackgroundImage");
            LoadGameButton.BackgroundImageLayout = ImageLayout.Stretch;
            LoadGameButton.FlatAppearance.BorderSize = 0;
            LoadGameButton.FlatStyle = FlatStyle.Flat;
            LoadGameButton.Font = new Font("Matura MT Script Capitals", 12F, FontStyle.Bold);
            LoadGameButton.ForeColor = Color.FromArgb(192, 0, 0);
            LoadGameButton.Location = new Point(314, 338);
            LoadGameButton.Margin = new Padding(1, 1, 1, 1);
            LoadGameButton.Name = "LoadGameButton";
            LoadGameButton.Size = new Size(131, 31);
            LoadGameButton.TabIndex = 1;
            LoadGameButton.Text = "Load Game";
            LoadGameButton.UseVisualStyleBackColor = false;
            LoadGameButton.Click += LoadGameButton_Click;
            // 
            // OptionsButton
            // 
            OptionsButton.Anchor = AnchorStyles.None;
            OptionsButton.BackColor = SystemColors.ControlDarkDark;
            OptionsButton.BackgroundImage = (Image)resources.GetObject("OptionsButton.BackgroundImage");
            OptionsButton.BackgroundImageLayout = ImageLayout.Stretch;
            OptionsButton.FlatAppearance.BorderSize = 0;
            OptionsButton.FlatStyle = FlatStyle.Flat;
            OptionsButton.Font = new Font("Matura MT Script Capitals", 12F, FontStyle.Bold);
            OptionsButton.ForeColor = Color.FromArgb(192, 0, 0);
            OptionsButton.Location = new Point(314, 384);
            OptionsButton.Margin = new Padding(1, 1, 1, 1);
            OptionsButton.Name = "OptionsButton";
            OptionsButton.Size = new Size(131, 30);
            OptionsButton.TabIndex = 2;
            OptionsButton.Text = "Options";
            OptionsButton.UseVisualStyleBackColor = false;
            OptionsButton.Click += OptionsButton_Click;
            // 
            // CreditsButton
            // 
            CreditsButton.Anchor = AnchorStyles.None;
            CreditsButton.BackColor = SystemColors.ControlDarkDark;
            CreditsButton.BackgroundImage = (Image)resources.GetObject("CreditsButton.BackgroundImage");
            CreditsButton.BackgroundImageLayout = ImageLayout.Stretch;
            CreditsButton.FlatAppearance.BorderSize = 0;
            CreditsButton.FlatStyle = FlatStyle.Flat;
            CreditsButton.Font = new Font("Matura MT Script Capitals", 12F, FontStyle.Bold);
            CreditsButton.ForeColor = Color.FromArgb(192, 0, 0);
            CreditsButton.Location = new Point(314, 428);
            CreditsButton.Margin = new Padding(1, 1, 1, 1);
            CreditsButton.Name = "CreditsButton";
            CreditsButton.Size = new Size(131, 29);
            CreditsButton.TabIndex = 3;
            CreditsButton.Text = "Credits";
            CreditsButton.UseVisualStyleBackColor = false;
            CreditsButton.Click += CreditsButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Anchor = AnchorStyles.None;
            ExitButton.BackColor = SystemColors.ControlDarkDark;
            ExitButton.BackgroundImage = (Image)resources.GetObject("ExitButton.BackgroundImage");
            ExitButton.BackgroundImageLayout = ImageLayout.Stretch;
            ExitButton.FlatAppearance.BorderSize = 0;
            ExitButton.FlatStyle = FlatStyle.Flat;
            ExitButton.Font = new Font("Matura MT Script Capitals", 12F, FontStyle.Bold);
            ExitButton.ForeColor = Color.FromArgb(192, 0, 0);
            ExitButton.Location = new Point(314, 472);
            ExitButton.Margin = new Padding(1, 1, 1, 1);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(131, 29);
            ExitButton.TabIndex = 4;
            ExitButton.Text = "Exit Game";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // GameSelectScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.selectScreen;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(752, 538);
            Controls.Add(ExitButton);
            Controls.Add(CreditsButton);
            Controls.Add(OptionsButton);
            Controls.Add(LoadGameButton);
            Controls.Add(NewGameButton);
            Margin = new Padding(1, 1, 1, 1);
            Name = "GameSelectScreen";
            Text = "Game Selection";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion

        private Button NewGameButton;
        private Button LoadGameButton;
        private Button OptionsButton;
        private Button CreditsButton;
        private Button ExitButton;
    }
}
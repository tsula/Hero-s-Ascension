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
            NewGameButton.ForeColor = Color.LightYellow;
            NewGameButton.Location = new Point(1000, 723);
            NewGameButton.Name = "NewGameButton";
            NewGameButton.Size = new Size(374, 93);
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
            LoadGameButton.ForeColor = Color.LightYellow;
            LoadGameButton.Location = new Point(1000, 858);
            LoadGameButton.Name = "LoadGameButton";
            LoadGameButton.Size = new Size(374, 99);
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
            OptionsButton.ForeColor = Color.LightYellow;
            OptionsButton.Location = new Point(1000, 1005);
            OptionsButton.Name = "OptionsButton";
            OptionsButton.Size = new Size(374, 96);
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
            CreditsButton.ForeColor = Color.LightYellow;
            CreditsButton.Location = new Point(1000, 1146);
            CreditsButton.Name = "CreditsButton";
            CreditsButton.Size = new Size(374, 93);
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
            ExitButton.ForeColor = Color.LightYellow;
            ExitButton.Location = new Point(1000, 1286);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(374, 93);
            ExitButton.TabIndex = 4;
            ExitButton.Text = "Exit Game";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // GameSelectScreen
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.selectScreen;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(2291, 1459);
            Controls.Add(ExitButton);
            Controls.Add(CreditsButton);
            Controls.Add(OptionsButton);
            Controls.Add(LoadGameButton);
            Controls.Add(NewGameButton);
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
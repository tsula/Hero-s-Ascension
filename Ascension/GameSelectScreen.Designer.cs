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
            NewGameButton = new Button();
            LoadGameButton = new Button();
            OptionsButton = new Button();
            CreditsButton = new Button();
            SuspendLayout();
            // 
            // NewGameButton
            // 
            NewGameButton.Location = new Point(428, 305);
            NewGameButton.Name = "NewGameButton";
            NewGameButton.Size = new Size(225, 69);
            NewGameButton.TabIndex = 0;
            NewGameButton.Text = "New Game";
            NewGameButton.UseVisualStyleBackColor = true;
            NewGameButton.Click += NewGameButton_Click;
            // 
            // LoadGameButton
            // 
            LoadGameButton.Location = new Point(430, 448);
            LoadGameButton.Name = "LoadGameButton";
            LoadGameButton.Size = new Size(225, 69);
            LoadGameButton.TabIndex = 1;
            LoadGameButton.Text = "Load Game";
            LoadGameButton.UseVisualStyleBackColor = true;
            LoadGameButton.Click += LoadGameButton_Click;
            // 
            // OptionsButton
            // 
            OptionsButton.Location = new Point(428, 595);
            OptionsButton.Name = "OptionsButton";
            OptionsButton.Size = new Size(225, 69);
            OptionsButton.TabIndex = 2;
            OptionsButton.Text = "Options";
            OptionsButton.UseVisualStyleBackColor = true;
            OptionsButton.Click += OptionsButton_Click;
            // 
            // CreditsButton
            // 
            CreditsButton.Location = new Point(428, 737);
            CreditsButton.Name = "CreditsButton";
            CreditsButton.Size = new Size(225, 69);
            CreditsButton.TabIndex = 3;
            CreditsButton.Text = "Credits";
            CreditsButton.UseVisualStyleBackColor = true;
            CreditsButton.Click += CreditsButton_Click;
            // 
            // GameSelectScreen
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.selectScreen;
            ClientSize = new Size(1029, 1026);
            Controls.Add(CreditsButton);
            Controls.Add(OptionsButton);
            Controls.Add(LoadGameButton);
            Controls.Add(NewGameButton);
            Name = "GameSelectScreen";
            Text = "Game Selection";
            ResumeLayout(false);
        }

        #endregion

        private Button NewGameButton;
        private Button LoadGameButton;
        private Button OptionsButton;
        private Button CreditsButton;
    }
}
using System;
using System.Windows.Forms;

namespace Ascension
{
    public partial class LoadGamePage : Form
    {
        public LoadGamePage()
        {
            InitializeComponent();
        }

        private void SignInBtn_Click(object sender, EventArgs e)
        {
            AudioManager.PlayEffectSound("Assets/Audio/UIMenu/Confirm.wav");

            Character savedCharacter = LoadSavedCharacter();

            if (savedCharacter != null)
            {
                GameManager.LoadCharacter(savedCharacter);

                // Navigate to the World Map
                WorldMap worldMap = new WorldMap();
                worldMap.Show();
                this.Hide();

                AudioManager.StopBackgroundSound(); // stop the background music
            }
            else
            {
                MessageBox.Show("Failed to load character. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Character LoadSavedCharacter()
        {
            try
            {
                // Get the username entered in the UserSignIn TextBox
                string username = UserSignIn?.Text.Trim();

                if (string.IsNullOrEmpty(username))
                {
                    MessageBox.Show("Please enter a username.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return null;
                }

                // Load the character from the database using DatabaseManager
                DatabaseManager dbManager = new DatabaseManager();
                Character loadedCharacter = dbManager.LoadCharacter(username);

                if (loadedCharacter == null)
                {
                    MessageBox.Show("Character not found in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }

                return loadedCharacter;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading the character: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            AudioManager.PlayEffectSound("Assets/Audio/UIMenu/Confirm.wav");

            GameSelectScreen gameSelectScreen = Application.OpenForms["GameSelectScreen"] as GameSelectScreen;

            if (gameSelectScreen == null)
            {
                gameSelectScreen = new GameSelectScreen();
            }

            gameSelectScreen.Show();
            this.Hide();
        }
    }
}

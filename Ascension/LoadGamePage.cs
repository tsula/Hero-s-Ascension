﻿using System;
using System.Windows.Forms;

namespace Ascension
{
    public partial class LoadGamePage : Form
    {
        public LoadGamePage()
        {
            InitializeComponent();

            // Attach PlayButtonClickSound to all buttons on the form
            foreach (Control control in this.Controls)
            {
                if (control is Button button)
                {
                    button.Click += PlayButtonClickSound;
                }
            }
        }

        private void PlayButtonClickSound(object sender, EventArgs e)
        {
            // Play confirm.wav for all button clicks
            AudioManager.PlayEffectSound("Assets/Audio/UIMenu/Confirm.wav");
        }

        private void SignInBtn_Click(object sender, EventArgs e)
        {
            Character savedCharacter = LoadSavedCharacter();

            if (savedCharacter != null)
            {
                // Assign the loaded character to the GameManager
                GameManager.LoadCharacter(savedCharacter);

                // Navigate to the World Map
                WorldMap worldMap = new WorldMap();
                worldMap.Show();
                this.Hide();

                // Stop the background music
                AudioManager.StopBackgroundSound();
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

                // Initialize the player with the username
                GameManager.InitializePlayer(username, loadedCharacter);

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

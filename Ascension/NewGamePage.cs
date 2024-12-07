using System;
using System.Windows.Forms;

namespace Ascension
{
    public partial class NewGamePage : Form
    {
        public NewGamePage()
        {
            InitializeComponent();

            // Add event handlers for radio button selection
            radioButton1.CheckedChanged += CharacterSelectionChanged;
            radioButton2.CheckedChanged += CharacterSelectionChanged;
            radioButton3.CheckedChanged += CharacterSelectionChanged;
        }

        private void CharacterSelectionChanged(object sender, EventArgs e)
        {
            // Play equip.wav sound when a character is selected
            if (((RadioButton)sender).Checked) // Only play sound when the radio button is checked
            {
                AudioManager.PlayEffectSound("Assets/Audio/UIMenu/Confirm.wav");
            }
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            // Play confirm sound effect
            AudioManager.PlayEffectSound("Assets/Audio/UIMenu/Confirm.wav");

            // Get the GameSelectScreen form instance
            GameSelectScreen gameSelectScreen = Application.OpenForms["GameSelectScreen"] as GameSelectScreen;
            if (gameSelectScreen != null)
            {
                // Show the previously hidden GameSelectScreen form
                gameSelectScreen.Show();
                this.Hide(); // Hide the current form
            }
            else
            {
                // If GameSelectScreen form is not found, create a new instance
                gameSelectScreen = new GameSelectScreen();
                gameSelectScreen.Show();
                this.Hide();
            }
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            AudioManager.PlayEffectSound("Assets/Audio/UIMenu/Confirm.wav");

            // Retrieve the selected class
            string selectedClass = "";
            if (radioButton1.Checked) selectedClass = "Knight";
            else if (radioButton2.Checked) selectedClass = "Wizard";
            else if (radioButton3.Checked) selectedClass = "Rogue";

            // Validate class selection
            if (string.IsNullOrEmpty(selectedClass))
            {
                MessageBox.Show("Please select a character class.", "Input Error");
                return;
            }

            // Get the username and password
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Validate inputs
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both a username and a password.", "Input Error");
                return;
            }

            // Create the new character and assign credentials
            try
            {
                GameManager.CreateNewCharacter(selectedClass, username);
                GameManager.PlayerCharacter.PasswordHash = password; // Store the password

                // Save the character to the database
                DatabaseManager dbManager = new DatabaseManager();
                dbManager.SavePlayerState(GameManager.PlayerCharacter);

                // Display specific message based on the selected class
                string message = selectedClass switch
                {
                    "Knight" => "You have chosen the path of the Knight!",
                    "Wizard" => "You have chosen the path of the Wizard!",
                    "Rogue" => "You have chosen the path of the Rogue!",
                    _ => "Character created successfully!"
                };

                MessageBox.Show($"Character created and saved successfully!\n{message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while creating the character: {ex.Message}", "Error");
                return;
            }

            // Navigate to the World Map
            WorldMap worldMap = new WorldMap();
            worldMap.Show();
            this.Hide();

            // Stop the background music
            AudioManager.StopBackgroundSound();
        }
    }
}

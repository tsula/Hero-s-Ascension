using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ascension
{
    public partial class NewGamePage : Form
    {
        public NewGamePage()
        {
            InitializeComponent();
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            GameSelectScreen gameSelectScreen = Application.OpenForms["GameSelectScreen"] as GameSelectScreen;
            if (gameSelectScreen != null)
            {
                gameSelectScreen.Show(); // Show the previously hidden form
                this.Hide();           // Hide the current form
            }
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            // Retrieve the selected class
            string selectedClass = "";
            if (radioButton1.Checked) selectedClass = "Knight";
            else if (radioButton2.Checked) selectedClass = "Wizard";
            else if (radioButton3.Checked) selectedClass = "Rogue";

            // Get the username and password
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Testing to see if the username and password are being stored correctly
            Console.WriteLine($"Username Entered: {username}");
            Console.WriteLine($"Password Entered: {password}");

            // Validate inputs
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both a username and a password.", "Input Error");
                return;
            }

            // Create the new character
            GameManager.CreateNewCharacter(selectedClass);

            // Assign username and password to the character
            GameManager.PlayerCharacter.Username = username;
            GameManager.PlayerCharacter.PasswordHash = password;    // removed hashing

            // Save the character to the database
            DatabaseManager dbManager = new DatabaseManager();
            try
            {
                dbManager.SaveCharacter(GameManager.PlayerCharacter);
                MessageBox.Show("Character created and saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving the character: {ex.Message}");
            }

            // Navigate to the World Map
            WorldMap worldMap = new WorldMap();
            worldMap.Show();
            this.Hide();
        }
    }
}

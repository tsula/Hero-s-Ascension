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

            // Validate inputs
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both a username and a password.", "Input Error");
                return;
            }

            // Hash the password (basic example, consider stronger hashing like BCrypt)
            string hashedPassword = HashPassword(password);

            // Create the new character
            GameManager.CreateNewCharacter(selectedClass);

            // Assign username and password to the character
            GameManager.PlayerCharacter.Username = username;
            GameManager.PlayerCharacter.PasswordHash = hashedPassword;

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

        // Hashing function (use a stronger algorithm like BCrypt for real applications)
        private string HashPassword(string password)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }

    }
}

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
            string selectedClass = ""; // Retrieve the selected class from the UI
            if (radioButton1.Checked) selectedClass = "Knight";
            else if (radioButton2.Checked) selectedClass = "Wizard";
            else if (radioButton3.Checked) selectedClass = "Rogue";

            GameManager.CreateNewCharacter(selectedClass);

            /*Save character details (optional)
             * 
            SaveCharacter(GameManager.PlayerCharacter);

            */

            // Navigate to the World Map
            WorldMap worldMap = new WorldMap();
            worldMap.Show();
            this.Hide();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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
            // Simulate loading a character from storage
            Character savedCharacter = LoadSavedCharacter();

            if (savedCharacter != null)
            {
                GameManager.LoadCharacter(savedCharacter);

                // Navigate to the World Map
                WorldMap worldMap = new WorldMap();
                worldMap.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No saved character found!");
            }
        }

        /* !!! PLACEHOLDER !!!
         * (replace with database logic)
         */
        private Character LoadSavedCharacter()
        {
            
            return new Knight(); // example
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            GameSelectScreen gameSelectScreen = Application.OpenForms["GameSelectScreen"] as GameSelectScreen;
            if (gameSelectScreen != null)
            {
                gameSelectScreen.Show();
                this.Hide();
            }
        }
    }
}

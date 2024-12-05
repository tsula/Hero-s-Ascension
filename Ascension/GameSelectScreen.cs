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
    public partial class GameSelectScreen : Form
    {
        public GameSelectScreen()
        {
            InitializeComponent();

            // Play background music for the select screen
            AudioManager.PlayBackgroundSound("Assets/Audio/Misc/worldmapLOOP.wav");
        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            NewGamePage newGamePage = new NewGamePage();
            newGamePage.Show();     // Goes to new game page
            this.Hide();
        }

        private void LoadGameButton_Click(object sender, EventArgs e)
        {
            LoadGamePage loadGamePage = new LoadGamePage();
            loadGamePage.Show();  // Goes to load game page
            this.Hide();
        }

        private void OptionsButton_Click(object sender, EventArgs e)
        {
            Options options = new Options();
            options.Show();     // Goes to game options
            this.Hide();
        }

        private void CreditsButton_Click(object sender, EventArgs e)
        {
            Credits credits = new Credits();
            credits.Show();     // Goes to game credits
            this.Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to exit the game?",
                                    "Confirm Exit",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                AudioManager.PlayEffectSound("Assets/Audio/UIMenu/Confirm.wav"); // Play confirmation sound if desired
                Application.Exit(); // Exit the application
            }
        }
    }
}

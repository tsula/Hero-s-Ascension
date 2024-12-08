using System;
using System.Windows.Forms;

namespace Ascension
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();

            // Load preferences on form load
            LoadPreferences();
        }

        private void LoadPreferences()
        {
            // Set the toggle states based on saved preferences
            MusicToggle.Checked = Settings1.Default.MusicEnabled;
            SoundToggle.Checked = Settings1.Default.SoundEnabled;
        }

        private void SavePreferences()
        {
            // Save preferences to settings
            Settings1.Default.MusicEnabled = MusicToggle.Checked;
            Settings1.Default.SoundEnabled = SoundToggle.Checked;
            Settings1.Default.Save();
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            SavePreferences(); // Save preferences before returning
            GameSelectScreen gameSelectScreen = Application.OpenForms["GameSelectScreen"] as GameSelectScreen;
            if (gameSelectScreen != null)
            {
                gameSelectScreen.Show();
                this.Hide();
            }
        }

        private void MusicToggle_CheckedChanged(object sender, EventArgs e)
        {
            // Update the AudioManager's music state
            AudioManager.IsMusicEnabled = MusicToggle.Checked;

            if (AudioManager.IsMusicEnabled)
            {
                // Restart the background music if toggled on
                AudioManager.PlayBackgroundSound("Assets/Audio/Misc/worldmapLOOP.wav");
            }
            else
            {
                // Stop the music if toggled off
                AudioManager.StopBackgroundSound();
            }
        }

        private void SoundToggle_CheckedChanged(object sender, EventArgs e)
        {
            // Update the AudioManager's sound effects state
            AudioManager.IsSoundEnabled = SoundToggle.Checked;
        }


    }
}

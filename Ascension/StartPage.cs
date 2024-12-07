namespace Ascension
{
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();

            // Play background music for the title screen
            if (AudioManager.IsMusicEnabled)
            {
                AudioManager.PlayBackgroundSound("Assets/Audio/Misc/title.wav");
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            // Play sound effect for confirmation
            AudioManager.PlayEffectSound("Assets/Audio/UIMenu/Confirm.wav");

            // Stop the current background music (title screen music)
            AudioManager.StopBackgroundSound();

            // Navigate to the GameSelectScreen
            GameSelectScreen gameSelectScreen = new GameSelectScreen();
            gameSelectScreen.Show();
            this.Hide();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            // Stop background music when leaving the form
            AudioManager.StopBackgroundSound();
        }
    }
}

namespace Ascension
{
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();

            // Play background music for the title screen
            AudioManager.PlayBackgroundSound("Assets/Audio/Misc/title.wav");
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            AudioManager.PlayEffectSound("Assets/Audio/UIMenu/Confirm.wav");
            GameSelectScreen gameSelectScreen = new GameSelectScreen(); 
            gameSelectScreen.Show();                                    // Show the GameSelectScreen
            this.Hide();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            AudioManager.StopBackgroundSound(); // Stop background music when leaving the form
        }
    }
}

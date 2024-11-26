namespace Ascension
{
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            GameSelectScreen gameSelectScreen = new GameSelectScreen(); 
            gameSelectScreen.Show();                                    // Show the GameSelectScreen
            this.Hide();
        }
    }
}

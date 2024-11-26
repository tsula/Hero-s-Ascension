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
    public partial class LoadGamePage : Form
    {
        public LoadGamePage()
        {
            InitializeComponent();
        }

        private void SignInBtn_Click(object sender, EventArgs e)
        {

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

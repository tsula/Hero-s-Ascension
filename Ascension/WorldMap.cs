using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ascension
{
    public partial class WorldMap : Form
    {
        private System.Windows.Forms.Timer animationTimer;
        private Image mapBackground; // Background image for the world map

        public WorldMap()
        {
            InitializeComponent();

            // Enable double buffering to reduce flickering
            this.DoubleBuffered = true;

            // Initialize the animation timer
            animationTimer = new System.Windows.Forms.Timer();
            animationTimer.Interval = 100; // Frame duration in milliseconds
            animationTimer.Tick += AnimationTimer_Tick;
            animationTimer.Start();

            // Load the world map background image from resources
            try
            {
                mapBackground = Properties.Resources.worldmap; // Adjust if the resource name is different
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load world map background: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mapBackground = null;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            // Draw the world map background
            if (mapBackground != null)
            {
                g.DrawImage(mapBackground, new Rectangle(0, 0, this.Width, this.Height));
            }

            // Draw the player character
            Character playerCharacter = GameManager.PlayerCharacter;

            if (playerCharacter.SpriteSheets.ContainsKey(playerCharacter.State))
            {
                Image spriteSheet = playerCharacter.SpriteSheets[playerCharacter.State];
                int frameX = playerCharacter.CurrentFrame * playerCharacter.FrameWidth;

                g.DrawImage(spriteSheet,
                    new Rectangle(playerCharacter.X, playerCharacter.Y, playerCharacter.FrameWidth, playerCharacter.FrameHeight), // Destination
                    new Rectangle(frameX, 0, playerCharacter.FrameWidth, playerCharacter.FrameHeight), // Source
                    GraphicsUnit.Pixel);
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            const int stepSize = 10; // Movement speed
            Character playerCharacter = GameManager.PlayerCharacter;

            if (playerCharacter == null)
            {
                Console.WriteLine("Player character is null.");
                return base.ProcessCmdKey(ref msg, keyData);
            }

            // Move the character based on the arrow keys
            switch (keyData)
            {
                case Keys.Up:
                    playerCharacter.Move(0, -stepSize);
                    break;
                case Keys.Down:
                    playerCharacter.Move(0, stepSize);
                    break;
                case Keys.Left:
                    playerCharacter.Move(-stepSize, 0);
                    break;
                case Keys.Right:
                    playerCharacter.Move(stepSize, 0);
                    break;
                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }


            Invalidate(); // Redraw the entire form
            return true;
        }


        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            // Update the animation frame for the player character
            Character playerCharacter = GameManager.PlayerCharacter;

            // Cycle through frames
            playerCharacter.CurrentFrame = (playerCharacter.CurrentFrame + 1) % playerCharacter.TotalFrames;

            Invalidate(); // Redraw the entire form
        }
    }
}

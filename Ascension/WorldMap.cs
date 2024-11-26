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
    public partial class WorldMap : Form
    {
        public WorldMap()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            Character playerCharacter = GameManager.PlayerCharacter;

            // Draw the character's current animation frame
            Image spriteSheet = playerCharacter.SpriteSheets[playerCharacter.State];
            int frameX = playerCharacter.CurrentFrame * playerCharacter.FrameWidth;

            g.DrawImage(spriteSheet,
                new Rectangle(playerCharacter.X, playerCharacter.Y, playerCharacter.FrameWidth, playerCharacter.FrameHeight), // Destination
                new Rectangle(frameX, 0, playerCharacter.FrameWidth, playerCharacter.FrameHeight), // Source
                GraphicsUnit.Pixel);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Ascension
{
    public partial class WorldMap : Form
    {
        private System.Windows.Forms.Timer animationTimer;
        private Image mapBackground; // Background image for the world map
        private List<Enemy> enemies; // List of enemies on the world map
        private Random random;       // Random generator for enemy spawning

        public WorldMap()
        {
            InitializeComponent();

            AudioManager.PlayBackgroundSound("Assets/Audio/Misc/worldmapLOOP.wav");

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

            // Initialize enemy list and random generator
            enemies = new List<Enemy>();
            random = new Random();

            SpawnEnemies(5); // Spawn 5 random enemies
        }

        private void SpawnEnemies(int count)
        {
            for (int i = 0; i < count; i++)
            {
                try
                {
                    // Randomly choose between Orc and Skeleton
                    Enemy enemy;
                    if (random.Next(2) == 0) // 50% chance for each
                    {
                        enemy = new Orc((Orc.OrcType)random.Next(4)); // Random Orc type
                    }
                    else
                    {
                        enemy = new Skeleton((Skeleton.SkeletonType)random.Next(4)); // Random Skeleton type
                    }

                    // Set animation dimensions based on sprite sheet and total frames
                    if (enemy.SpriteSheets.ContainsKey(Enemy.EnemyState.Idle))
                    {
                        enemy.SetAnimationDimensions(enemy.SpriteSheets[Enemy.EnemyState.Idle], 6); // Assuming 6 frames per animation
                    }

                    // Set random position for the enemy
                    enemy.X = random.Next(0, this.Width - (enemy.FrameWidth * 3));
                    enemy.Y = random.Next(0, this.Height - (enemy.FrameHeight * 3));

                    enemies.Add(enemy); // Add to the enemies list
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Failed to create enemy: {ex.Message}");
                }
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

                // Scale the player sprite by 3x
                int scaledWidth = playerCharacter.FrameWidth * 3;
                int scaledHeight = playerCharacter.FrameHeight * 3;

                g.DrawImage(spriteSheet,
                    new Rectangle(playerCharacter.X, playerCharacter.Y, scaledWidth, scaledHeight), // Destination (scaled size)
                    new Rectangle(frameX, 0, playerCharacter.FrameWidth, playerCharacter.FrameHeight), // Source (original size)
                    GraphicsUnit.Pixel);
            }

            // Draw the enemies
            foreach (var enemy in enemies)
            {
                if (enemy.SpriteSheets.ContainsKey(enemy.State))
                {
                    Image spriteSheet = enemy.SpriteSheets[enemy.State];
                    int frameX = enemy.CurrentFrame * enemy.FrameWidth;

                    // Scale the enemy sprite by 3x
                    int scaledWidth = enemy.FrameWidth * 3;
                    int scaledHeight = enemy.FrameHeight * 3;

                    g.DrawImage(spriteSheet,
                        new Rectangle(enemy.X, enemy.Y, scaledWidth, scaledHeight), // Destination (scaled size)
                        new Rectangle(frameX, 0, enemy.FrameWidth, enemy.FrameHeight), // Source (original size)
                        GraphicsUnit.Pixel);
                }
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
            playerCharacter.CurrentFrame = (playerCharacter.CurrentFrame + 1) % playerCharacter.TotalFrames;

            // Update the animation frames for all enemies
            foreach (var enemy in enemies)
            {
                enemy.UpdateAnimationFrame();
            }

            Invalidate(); // Redraw the entire form
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure the player character exists
                Character playerCharacter = GameManager.PlayerCharacter;
                if (playerCharacter == null || string.IsNullOrWhiteSpace(playerCharacter.Username))
                {
                    MessageBox.Show("Player character not found or username is missing. Save failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Save player state and enemies
                DatabaseManager dbManager = new DatabaseManager();
                dbManager.SavePlayerState(playerCharacter); // Save player state
                dbManager.SaveEnemyState(enemies, playerCharacter.Username); // Save enemies associated with the player

                // Provide feedback
                AudioManager.PlayEffectSound("Assets/Audio/UIMenu/Save.wav");
                MessageBox.Show("Game saved successfully!", "Save Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving the game: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            AudioManager.PlayEffectSound("Assets/Audio/UIMenu/Confirm.wav");
            GameSelectScreen gameSelectScreen = Application.OpenForms["GameSelectScreen"] as GameSelectScreen;
            if (gameSelectScreen != null)
            {
                gameSelectScreen.Show(); // Show the previously hidden form
                this.Hide();           // Hide the current form
            }
        }
    }
}

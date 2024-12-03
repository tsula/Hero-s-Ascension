using System;
using System.Collections.Generic;
using System.Drawing;

namespace Ascension
{
    public abstract class Enemy
    {
        // Basic Properties for all enemies
        public string Name { get; set; }
        public int Health { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Speed { get; set; }

        // Animation and State
        public enum EnemyState { Idle, Running, Dead }
        public EnemyState State { get; set; }
        public Dictionary<EnemyState, Image> SpriteSheets { get; set; } = new();
        public int CurrentFrame { get; set; }
        public int FrameWidth { get; set; }
        public int FrameHeight { get; set; }
        public int TotalFrames { get; set; }

        // Position on the world map
        public int X { get; set; }
        public int Y { get; set; }

        // Constructor for the base Enemy class
        protected Enemy(string name, int health, int attack, int defense, int speed, int frameWidth, int frameHeight)
        {
            Name = name;
            Health = health;
            Attack = attack;
            Defense = defense;
            Speed = speed;
            FrameWidth = frameWidth;
            FrameHeight = frameHeight;
            State = EnemyState.Idle; // Default state
            X = 0; // Default start position
            Y = 0;
        }

        // Load sprites for the enemy
        public void LoadSprites(string idlePath, string runPath, string deathPath)
        {
            try
            {
                SpriteSheets[EnemyState.Idle] = Image.FromFile(idlePath);
                SpriteSheets[EnemyState.Running] = Image.FromFile(runPath);
                SpriteSheets[EnemyState.Dead] = Image.FromFile(deathPath);
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to load sprite sheet: {ex.Message}");
            }
        }

        // Move the enemy
        public void Move(int dx, int dy)
        {
            X += dx;
            Y += dy;

            State = (dx == 0 && dy == 0) ? EnemyState.Idle : EnemyState.Running;
        }

        // Attack method for the enemy
        public virtual int AttackPlayer()
        {
            return Attack; // Can be overridden for specific enemy types
        }

        // Update the animation frame
        public void UpdateAnimationFrame()
        {
            CurrentFrame = (CurrentFrame + 1) % TotalFrames;
        }

        // Draw the enemy on the world map
        public void Draw(Graphics g)
        {
            if (SpriteSheets.ContainsKey(State))
            {
                Image spriteSheet = SpriteSheets[State];
                int frameX = CurrentFrame * FrameWidth;

                g.DrawImage(spriteSheet,
                    new Rectangle(X, Y, FrameWidth, FrameHeight),       // Destination
                    new Rectangle(frameX, 0, FrameWidth, FrameHeight), // Source
                    GraphicsUnit.Pixel);
            }
        }
    }
}

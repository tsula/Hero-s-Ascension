using System;
using System.Collections.Generic;
using System.Drawing;

namespace Ascension
{
    public class Character
    {
        // Base Properties
        public string Name { get; set; }
        public int Health { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Speed { get; set; }

        // Animation and State
        public enum CharacterState { Idle, Running, Dead }
        public CharacterState State { get; set; }
        public Dictionary<CharacterState, Image> SpriteSheets { get; set; } = new();
        public int CurrentFrame { get; set; }
        public int FrameWidth { get; set; }
        public int FrameHeight { get; set; }
        public int TotalFrames { get; set; }

        // Position on the world map
        public int X { get; set; }
        public int Y { get; set; }

        // Login Information
        public string Username { get; set; }
        public string PasswordHash { get; set; }

        // Constructor
        public Character(string name, int health, int attack, int defense, int speed, int frameWidth, int frameHeight)
        {
            Name = name;
            Health = health;
            Attack = attack;
            Defense = defense;
            Speed = speed;

            FrameWidth = 128 / 4; // 32 pixels per frame
            FrameHeight = 32;

            State = CharacterState.Idle; // Default state
            X = 0; // Default start position
            Y = 0;
            TotalFrames = 4; // Assuming 4 frames per animation
        }

        // Load Sprites with Error Handling
        public void LoadSprites(string idlePath, string runPath, string deathPath)
        {
            try
            {
                SpriteSheets[CharacterState.Idle] = Image.FromFile(idlePath);
                SpriteSheets[CharacterState.Running] = Image.FromFile(runPath);
                SpriteSheets[CharacterState.Dead] = Image.FromFile(deathPath);
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to load sprite sheet: {ex.Message}");
            }
        }

        // Move Character
        public void Move(int dx, int dy)
        {
            X += dx;
            Y += dy;

            // Update state based on movement
            if (dx == 0 && dy == 0)
            {
                State = CharacterState.Idle;
            }
            else
            {
                State = CharacterState.Running;
            }
        }

        // Update Animation Frame
        public void UpdateAnimationFrame()
        {
            // Increment frame with wrapping
            CurrentFrame = (CurrentFrame + 1) % TotalFrames;
        }

        // Attack method
        public virtual int AttackEnemy()
        {
            return Attack; // Can be overridden for unique attack logic
        }

        // Draw Character on the World Map
        public void Draw(Graphics g)
        {
            if (SpriteSheets.ContainsKey(State))
            {
                Image spriteSheet = SpriteSheets[State];
                int frameX = CurrentFrame * FrameWidth;

                // Draw the current animation frame
                g.DrawImage(spriteSheet,
                    new Rectangle(X, Y, FrameWidth, FrameHeight),       // Destination
                    new Rectangle(frameX, 0, FrameWidth, FrameHeight), // Source
                    GraphicsUnit.Pixel);
            }
        }
    }
}
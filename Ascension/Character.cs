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
        public int FrameWidth { get; private set; }
        public int FrameHeight { get; private set; }
        public int TotalFrames { get; private set; }

        // Position on the world map
        public int X { get; set; }
        public int Y { get; set; }

        // Login Information
        public string Username { get; set; }
        public string PasswordHash { get; set; }

        // Constructor
        public Character(string name, int health, int attack, int defense, int speed)
        {
            Name = name;
            Health = health;
            Attack = attack;
            Defense = defense;
            Speed = speed;

            X = 0;
            Y = 0;

            State = CharacterState.Idle; // Default state
        }

        // Load Sprites with Error Handling
        public void LoadSprites(string idlePath, string runPath, string deathPath)
        {
            try
            {
                SpriteSheets[CharacterState.Idle] = Image.FromFile(idlePath);
                SpriteSheets[CharacterState.Running] = Image.FromFile(runPath);
                SpriteSheets[CharacterState.Dead] = Image.FromFile(deathPath);

                // Default dimensions for Idle
                SetAnimationDimensions(CharacterState.Idle, 128, 32, 4); // 128x32, 4 frames

                // Default dimensions for Running
                SetAnimationDimensions(CharacterState.Running, 384, 64, 6); // 384x64, 6 frames
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to load sprite sheet: {ex.Message}");
            }
        }

        // Set animation dimensions for a specific state
        private void SetAnimationDimensions(CharacterState state, int sheetWidth, int sheetHeight, int frameCount)
        {
            if (SpriteSheets.ContainsKey(state))
            {
                FrameWidth = sheetWidth / frameCount;
                FrameHeight = sheetHeight;
                TotalFrames = frameCount;
            }
        }

        // Move Character
        public void Move(int dx, int dy)
        {
            X += dx;
            Y += dy;

            // Ensure the character remains within the screen bounds
            X = Math.Max(0, Math.Min(X, 1059 - FrameWidth * 3));
            Y = Math.Max(0, Math.Min(Y, 1133 - FrameHeight * 3));

            // Update state based on movement
            State = (dx == 0 && dy == 0) ? CharacterState.Idle : CharacterState.Running;

            // Update animation dimensions for the current state
            switch (State)
            {
                case CharacterState.Idle:
                    SetAnimationDimensions(CharacterState.Idle, 128, 32, 4);
                    break;
                case CharacterState.Running:
                    SetAnimationDimensions(CharacterState.Running, 384, 64, 6);
                    break;
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
                    new Rectangle(X, Y, FrameWidth * 3, FrameHeight * 3), // Scale 3x
                    new Rectangle(frameX, 0, FrameWidth, FrameHeight),   // Source
                    GraphicsUnit.Pixel);
            }
        }
    }
}

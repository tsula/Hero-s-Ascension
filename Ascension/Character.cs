using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        // Constructor
        public Character(string name, int health, int attack, int defense, int speed, int frameWidth, int frameHeight)
        {
            Name = name;
            Health = health;
            Attack = attack;
            Defense = defense;
            Speed = speed;
            FrameWidth = frameWidth;
            FrameHeight = frameHeight;
            State = CharacterState.Idle; // Default state

            X = 0; // Default start position
            Y = 0;
        }

        // Load Sprites 
        public void LoadSprites(string idlePath, string runPath, string deathPath)
        {
            SpriteSheets[CharacterState.Idle] = Image.FromFile(idlePath);
            SpriteSheets[CharacterState.Running] = Image.FromFile(runPath);
            SpriteSheets[CharacterState.Dead] = Image.FromFile(deathPath);
        }

        // Move Character
        public void Move(int dx, int dy)
        {
            X += dx;
            Y += dy;
            State = (dx == 0 && dy == 0) ? CharacterState.Idle : CharacterState.Running;
        }

        // Attack method
        public virtual int AttackEnemy()
        {
            return Attack; // Can be overridden for unique attack logic
        }
    }

}

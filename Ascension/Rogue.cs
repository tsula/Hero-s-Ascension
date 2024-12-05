using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ascension
{
    public class Rogue : Character
    {
        public Rogue()
            : base("Rogue", 90, 12, 7, 10)
        {
            LoadSprites(
        "Assets/Heroes/Rogue/Idle/Idle-Sheet.png",
        "Assets/Heroes/Rogue/Run/Run-Sheet.png",
        "Assets/Heroes/Rogue/Death/Death-Sheet.png");
        }

        public override int AttackEnemy()
        {
            Random rand = new Random();
            return rand.Next(0, 2) == 0 ? Attack * 2 : Attack; // 50% chance critical hit
        }
    }
}

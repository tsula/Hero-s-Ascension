using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ascension
{
    public class Wizard : Character
    {
        public Wizard()
            : base("Wizard", 80, 20, 5, 7, 100, 100) 
            {
            LoadSprites(
        "Assets/Heroes/Wizard/Idle/Idle-Sheet.png",
        "Assets/Heroes/Wizard/Run/Run-Sheet.png",
        "Assets/Heroes/Wizard/Death/Death-Sheet.png");
        }

        public override int AttackEnemy()
        {
            return Attack * 2;      // Mage has a powerful magic attack
        }
    }
}

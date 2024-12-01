using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ascension
{
    public class Knight : Character
    {
        public Knight()
     : base("Knight", 100, 15, 10, 5, 64, 64)
        {
            LoadSprites(
                "Assets/Heroes/Knight/Idle/Idle-Sheet.png",
                "Assets/Heroes/Knight/Run/Run-Sheet.png",
                "Assets/Heroes/Knight/Death/Death-Sheet.png");
        }

        // ADD = a defense or melee based override for this class?
    }
}

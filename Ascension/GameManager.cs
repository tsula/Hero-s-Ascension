using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ascension
{
    public static class GameManager
    {
        public static Character PlayerCharacter { get; set; }

        public static void CreateNewCharacter(string characterType)
        {
            // Create a new character based on the type chosen
            switch (characterType)
            {
                case "Knight":
                    PlayerCharacter = new Knight();
                    Console.WriteLine("You have chosen the path of the Knight!");
                    break;
                case "Wizard":
                    PlayerCharacter = new Wizard();
                    Console.WriteLine("You have chosen the path of the Wizard!");
                    break;
                case "Rogue":
                    PlayerCharacter = new Rogue();
                    Console.WriteLine("You have chosen the path of the Rogue!");
                    break;
                default:
                    throw new ArgumentException("Invalid character type");
            }
        }

        public static void LoadCharacter(Character savedCharacter)
        {
            PlayerCharacter = savedCharacter;
        }
    }

}

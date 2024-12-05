using System;

namespace Ascension
{
    public static class GameManager
    {
        // The current player character
        public static Character PlayerCharacter { get; set; }

        // Creates a new character based on the selected type and assigns the username
        public static void CreateNewCharacter(string characterType, string username)
        {
            switch (characterType)
            {
                case "Knight":
                    PlayerCharacter = new Knight();
                    break;
                case "Wizard":
                    PlayerCharacter = new Wizard();
                    break;
                case "Rogue":
                    PlayerCharacter = new Rogue();
                    break;
                default:
                    throw new ArgumentException("Invalid character type");
            }

            PlayerCharacter.Username = username;
        }

        // Loads a saved character into the game
        public static void LoadCharacter(Character savedCharacter)
        {
            PlayerCharacter = savedCharacter;
        }

        // Initializes a player with the given username and character
        public static void InitializePlayer(string username, Character character)
        {
            character.Username = username;
            PlayerCharacter = character;
        }
    }
}

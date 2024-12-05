using Ascension;

public class Orc : Enemy
{
    public enum OrcType { Base, Rogue, Shaman, Warrior }
    public OrcType Type { get; private set; }

    public Orc(OrcType type)
        : base("Orc", 70, 15, 10, 4) // Default stats for Orc Base
    {
        Type = type;

        // Adjust stats and load specific sprites based on the Orc type
        switch (type)
        {
            case OrcType.Rogue:
                Name = "Orc - Rogue";
                Health = 60;
                Attack = 20;
                Defense = 8;
                Speed = 6;
                LoadSprites(
                    "Assets/Enemies/Orc Crew/Orc - Rogue/Idle/Idle-Sheet.png",
                    "Assets/Enemies/Orc Crew/Orc - Rogue/Run/Run-Sheet.png",
                    "Assets/Enemies/Orc Crew/Orc - Rogue/Death/Death-Sheet.png"
                );
                break;

            case OrcType.Shaman:
                Name = "Orc - Shaman";
                Health = 50;
                Attack = 25;
                Defense = 5;
                Speed = 3;
                LoadSprites(
                    "Assets/Enemies/Orc Crew/Orc - Shaman/Idle/Idle-Sheet.png",
                    "Assets/Enemies/Orc Crew/Orc - Shaman/Run/Run-Sheet.png",
                    "Assets/Enemies/Orc Crew/Orc - Shaman/Death/Death-Sheet.png"
                );
                break;

            case OrcType.Warrior:
                Name = "Orc - Warrior";
                Health = 80;
                Attack = 18;
                Defense = 15;
                Speed = 4;
                LoadSprites(
                    "Assets/Enemies/Orc Crew/Orc - Warrior/Idle/Idle-Sheet.png",
                    "Assets/Enemies/Orc Crew/Orc - Warrior/Run/Run-Sheet.png",
                    "Assets/Enemies/Orc Crew/Orc - Warrior/Death/Death-Sheet.png"
                );
                break;

            case OrcType.Base:
            default:
                Name = "Orc";
                LoadSprites(
                    "Assets/Enemies/Orc Crew/Orc/Idle/Idle-Sheet.png",
                    "Assets/Enemies/Orc Crew/Orc/Run/Run-Sheet.png",
                    "Assets/Enemies/Orc Crew/Orc/Death/Death-Sheet.png"
                );
                break;
        }
    }
}

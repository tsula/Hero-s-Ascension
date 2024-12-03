using Ascension;

public class Skeleton : Enemy
{
    public enum SkeletonType { Base, Mage, Rogue, Warrior }
    public SkeletonType Type { get; private set; }

    public Skeleton(SkeletonType type)
        : base("Skeleton", 50, 10, 8, 5, 64, 64) // Default stats for Skeleton Base
    {
        Type = type;

        // Adjust stats and load specific sprites based on the Skeleton type
        switch (type)
        {
            case SkeletonType.Mage:
                Name = "Skeleton - Mage";
                Health = 40;
                Attack = 30;
                Defense = 5;
                Speed = 5;
                LoadSprites(
                    "Assets/Enemies/Skeleton/Skeleton - Mage/Idle/Idle-Sheet.png",
                    "Assets/Enemies/Skeleton/Skeleton - Mage/Run/Run-Sheet.png",
                    "Assets/Enemies/Skeleton/Skeleton - Mage/Death/Death-Sheet.png"
                );
                break;

            case SkeletonType.Rogue:
                Name = "Skeleton - Rogue";
                Health = 45;
                Attack = 20;
                Defense = 6;
                Speed = 8;
                LoadSprites(
                    "Assets/Enemies/Skeleton/Skeleton - Rogue/Idle/Idle-Sheet.png",
                    "Assets/Enemies/Skeleton/Skeleton - Rogue/Run/Run-Sheet.png",
                    "Assets/Enemies/Skeleton/Skeleton - Rogue/Death/Death-Sheet.png"
                );
                break;

            case SkeletonType.Warrior:
                Name = "Skeleton - Warrior";
                Health = 70;
                Attack = 15;
                Defense = 12;
                Speed = 4;
                LoadSprites(
                    "Assets/Enemies/Skeleton Crew/Skeleton - Warrior/Idle/Idle-Sheet.png",
                    "Assets/Enemies/Skeleton Crew/Skeleton - Warrior/Run/Run-Sheet.png",
                    "Assets/Enemies/Skeleton Crew/Skeleton - Warrior/Death/Death-Sheet.png"
                );
                break;

            case SkeletonType.Base:
            default:
                Name = "Skeleton";
                LoadSprites(
                    "Assets/Enemies/Skeleton Crew/Skeleton - Base/Idle/Idle-Sheet.png",
                    "Assets/Enemies/Skeleton Crew/Skeleton - Base/Run/Run-Sheet.png",
                    "Assets/Enemies/Skeleton Crew/Skeleton - Base/Death/Death-Sheet.png"
                );
                break;
        }
    }
}

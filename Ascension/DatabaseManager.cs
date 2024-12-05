using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace Ascension
{
    public class DatabaseManager
    {
        private const string ConnectionString = "Server=tcp:ascension.database.windows.net,1433;Initial Catalog=GameDB;Persist Security Info=False;User ID=teambfb;Password=Gametime2024;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=60;";

        // Save the player's character state
        public void SavePlayerState(Character player)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                var command = new SqlCommand(
                    "UPDATE Characters SET Name=@Name, ClassType=@ClassType, Health=@Health, Attack=@Attack, Defense=@Defense, Speed=@Speed, PositionX=@PositionX, PositionY=@PositionY " +
                    "WHERE Username=@Username; IF @@ROWCOUNT = 0 " +
                    "INSERT INTO Characters (Name, ClassType, Health, Attack, Defense, Speed, PositionX, PositionY, Username, PasswordHash) " +
                    "VALUES (@Name, @ClassType, @Health, @Attack, @Defense, @Speed, @PositionX, @PositionY, @Username, @PasswordHash);", connection);

                command.Parameters.AddWithValue("@Name", player.Name);
                command.Parameters.AddWithValue("@ClassType", player.GetType().Name);
                command.Parameters.AddWithValue("@Health", player.Health);
                command.Parameters.AddWithValue("@Attack", player.Attack);
                command.Parameters.AddWithValue("@Defense", player.Defense);
                command.Parameters.AddWithValue("@Speed", player.Speed);
                command.Parameters.AddWithValue("@PositionX", player.X);
                command.Parameters.AddWithValue("@PositionY", player.Y);
                command.Parameters.AddWithValue("@Username", player.Username);
                command.Parameters.AddWithValue("@PasswordHash", player.PasswordHash);

                command.ExecuteNonQuery();
            }
        }

        // Load a player's character state
        public Character LoadCharacter(string username)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM Characters WHERE Username = @Username", connection);
                command.Parameters.AddWithValue("@Username", username);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string classType = reader["ClassType"].ToString();
                        string name = reader["Name"].ToString();
                        int health = Convert.ToInt32(reader["Health"]);
                        int attack = Convert.ToInt32(reader["Attack"]);
                        int defense = Convert.ToInt32(reader["Defense"]);
                        int speed = Convert.ToInt32(reader["Speed"]);
                        int x = Convert.ToInt32(reader["PositionX"]);
                        int y = Convert.ToInt32(reader["PositionY"]);
                        string passwordHash = reader["PasswordHash"].ToString();

                        // Create the character based on the class type
                        Character character = classType switch
                        {
                            "Knight" => new Knight(),
                            "Wizard" => new Wizard(),
                            "Rogue" => new Rogue(),
                            _ => throw new Exception("Unknown character class."),
                        };

                        // Assign properties to the character
                        character.Name = name;
                        character.Health = health;
                        character.Attack = attack;
                        character.Defense = defense;
                        character.Speed = speed;
                        character.X = x;
                        character.Y = y;
                        character.Username = username;
                        character.PasswordHash = passwordHash;

                        return character;
                    }
                    else
                    {
                        throw new Exception("Character not found.");
                    }
                }
            }
        }



        // Save the states of all enemies
        public void SaveEnemyState(List<Enemy> enemies, string username)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                // Clear old enemy records for this user
                var deleteCommand = new SqlCommand("DELETE FROM Enemies WHERE Username = @Username", connection);
                deleteCommand.Parameters.AddWithValue("@Username", username);
                deleteCommand.ExecuteNonQuery();

                // Save each enemy's state
                foreach (var enemy in enemies)
                {
                    var insertCommand = new SqlCommand(
                        "INSERT INTO Enemies (Name, Type, Health, Attack, Defense, Speed, PositionX, PositionY, State, Username) " +
                        "VALUES (@Name, @Type, @Health, @Attack, @Defense, @Speed, @PositionX, @PositionY, @State, @Username)", connection);

                    insertCommand.Parameters.AddWithValue("@Name", enemy.Name);
                    insertCommand.Parameters.AddWithValue("@Type", enemy.GetType().Name);
                    insertCommand.Parameters.AddWithValue("@Health", enemy.Health);
                    insertCommand.Parameters.AddWithValue("@Attack", enemy.Attack);
                    insertCommand.Parameters.AddWithValue("@Defense", enemy.Defense);
                    insertCommand.Parameters.AddWithValue("@Speed", enemy.Speed);
                    insertCommand.Parameters.AddWithValue("@PositionX", enemy.X);
                    insertCommand.Parameters.AddWithValue("@PositionY", enemy.Y);
                    insertCommand.Parameters.AddWithValue("@State", enemy.State.ToString());
                    insertCommand.Parameters.AddWithValue("@Username", username);

                    insertCommand.ExecuteNonQuery();
                }
            }
        }

        // Load the states of all enemies
        public List<Enemy> LoadEnemyState(string username)
        {
            var enemies = new List<Enemy>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM Enemies WHERE Username = @Username", connection);
                command.Parameters.AddWithValue("@Username", username);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string name = reader["Name"].ToString();
                        string type = reader["Type"].ToString();
                        int health = Convert.ToInt32(reader["Health"]);
                        int attack = Convert.ToInt32(reader["Attack"]);
                        int defense = Convert.ToInt32(reader["Defense"]);
                        int speed = Convert.ToInt32(reader["Speed"]);
                        int x = Convert.ToInt32(reader["PositionX"]);
                        int y = Convert.ToInt32(reader["PositionY"]);
                        string state = reader["State"].ToString();

                        Enemy enemy = type switch
                        {
                            "Orc" => new Orc((Orc.OrcType)Enum.Parse(typeof(Orc.OrcType), name.Split('-')[1].Trim())),
                            "Skeleton" => new Skeleton((Skeleton.SkeletonType)Enum.Parse(typeof(Skeleton.SkeletonType), name.Split('-')[1].Trim())),
                            _ => null
                        };

                        if (enemy != null)
                        {
                            enemy.Health = health;
                            enemy.Attack = attack;
                            enemy.Defense = defense;
                            enemy.Speed = speed;
                            enemy.X = x;
                            enemy.Y = y;
                            enemy.State = Enum.Parse<Enemy.EnemyState>(state);

                            enemies.Add(enemy);
                        }
                    }
                }
            }

            return enemies;
        }
    }
}

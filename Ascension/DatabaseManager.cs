using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ascension
{
    using System;
    using System.Data.SqlClient;
    using System.Threading;

    public class DatabaseManager
    {
        private const string ConnectionString = "Server=tcp:ascension.database.windows.net,1433;Initial Catalog=GameDB;Persist Security Info=False;User ID=teambfb;Password=Gametime2024;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=60;";

        public void SaveCharacter(Character character)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                Console.WriteLine($"Saving Character: Username={character.Username}, PasswordHash={character.PasswordHash}");


                var command = new SqlCommand(
                     "INSERT INTO Characters (Name, ClassType, Health, Attack, Defense, Speed, PositionX, PositionY, Username, PasswordHash) " +
                      "VALUES (@Name, @ClassType, @Health, @Attack, @Defense, @Speed, @PositionX, @PositionY, @Username, @PasswordHash)", connection);


                command.Parameters.AddWithValue("@Name", character.Name);
                command.Parameters.AddWithValue("@ClassType", character.GetType().Name); // E.g., Warrior, Mage
                command.Parameters.AddWithValue("@Health", character.Health);
                command.Parameters.AddWithValue("@Attack", character.Attack);
                command.Parameters.AddWithValue("@Defense", character.Defense);
                command.Parameters.AddWithValue("@Speed", character.Speed);
                command.Parameters.AddWithValue("@PositionX", character.X);
                command.Parameters.AddWithValue("@PositionY", character.Y);

                command.Parameters.AddWithValue("@Username", character.Username);
                command.Parameters.AddWithValue("@PasswordHash", character.PasswordHash);

                command.ExecuteNonQuery();
            }
        }

        public Character LoadCharacter(string characterName)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM Characters WHERE Username = @Username", connection);
                command.Parameters.AddWithValue("@Username", characterName);

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

                        string username = reader["Username"].ToString();
                        string passwordHash = reader["PasswordHash"].ToString();

                        return classType switch
                        {
                            "Knight" => new Knight { Name = name, Health = health, Attack = attack, Defense = defense, Speed = speed, X = x, Y = y },
                            "Wizard" => new Wizard { Name = name, Health = health, Attack = attack, Defense = defense, Speed = speed, X = x, Y = y },
                            "Rogue" => new Rogue { Name = name, Health = health, Attack = attack, Defense = defense, Speed = speed, X = x, Y = y },
                            _ => throw new Exception("Unknown character class."),
                        };
                    }
                    else
                    {
                        throw new Exception("Character not found.");
                    }
                }
            }
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player_and_Team_Requirement
{
    internal class Program
    {
      static void Main(string[] args)
        {
            OneDayTeam team = new OneDayTeam();

            while (true)
            {
                Console.WriteLine("Enter 1: To Add Player 2: To Remove Player by Id 3. Get Player By Id 4. Get Player by Name 5. Get All Players:");
                string choiceStr = Console.ReadLine();
                int choice;
                if (int.TryParse(choiceStr, out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter Player Id: ");
                            int playerId = int.Parse(Console.ReadLine());

                            Console.Write("Enter Player Name: ");
                            string playerName = Console.ReadLine();

                            Console.Write("Enter Player Age: ");
                            int playerAge = int.Parse(Console.ReadLine());

                            Player newPlayer = new Player
                            {
                                PlayerId = playerId,
                                PlayerName = playerName,
                                PlayerAge = playerAge
                            };

                            team.Add(newPlayer);
                            break;
                        case 2:
                            Console.Write("Enter Player Id to Remove: ");
                            int playerIdToRemove = int.Parse(Console.ReadLine());
                            team.Remove(playerIdToRemove);
                            break;
                        case 3:
                            Console.Write("Enter Player Id to Get: ");
                            int playerIdToGet = int.Parse(Console.ReadLine());
                            Player playerById = team.GetPlayerById(playerIdToGet);
                            if (playerById != null)
                            {
                                Console.WriteLine($"Player found: {playerById.PlayerName}, Age: {playerById.PlayerAge}");
                            }
                            else
                            {
                                Console.WriteLine("Player not found.");
                            }
                            break;
                        case 4:
                            Console.Write("Enter Player Name to Get: ");
                            string playerNameToGet = Console.ReadLine();
                            Player playerByName = team.GetPlayerByName(playerNameToGet);
                            if (playerByName != null)
                            {
                                Console.WriteLine($"Player found: {playerByName.PlayerName}, Age: {playerByName.PlayerAge}");
                            }
                            else
                            {
                                Console.WriteLine("Player not found.");
                            }
                            break;
                        case 5:
                            List<Player> allPlayers = team.GetAllPlayers();
                            foreach (Player player in allPlayers)
                            {
                                Console.WriteLine($"Id: {player.PlayerId}, Name: {player.PlayerName}, Age: {player.PlayerAge}");
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
        }
    }

}


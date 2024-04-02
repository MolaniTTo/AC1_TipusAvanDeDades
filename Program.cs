using System;
using System.Xml.Schema;
using AC1_TipusAvançatsDeDades;

namespace AC1
{
    public class Program
    {
        public static void Main()
        {
            List<Score> scores = new List<Score>();

            for (int i = 0; i <10; i++)
            {
                Console.WriteLine("Player:");
                string player = Console.ReadLine();
                Console.WriteLine("Mission:");
                string mission = Console.ReadLine();
                Console.WriteLine("Scoring:");
                int scoring = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Player {i + 1} added!");

                Score score = new Score
                {
                    Player = player,
                    Mission = mission,
                    Scoring = scoring
                };

                scores.Add(score);
            }

            


        }
    }
}
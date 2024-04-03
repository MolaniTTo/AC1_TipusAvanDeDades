using AC1Score;
using AC1_Validations;
using System;

namespace AC1_TipusAvanDades
{
    public class Program
    {
        public static void Main()
        {
            string Player, Mission;
            int Scoring;

            List<Score> scores = new List<Score>();

            for (int i = 0; i < 4; i++)
            {

                do
                {
                    Console.WriteLine("Enter player name: ");
                    Player = Console.ReadLine();

                } while (!CheckValidations.ValidatePlayer(Player));

                do
                {
                    Console.WriteLine("Enter mission name: ");
                    Mission = Console.ReadLine();

                } while (!CheckValidations.ValidateMission(Mission));

                do
                {
                    Console.WriteLine("Enter scoring: ");
                    Scoring = Convert.ToInt32(Console.ReadLine());

                } while (!CheckValidations.ValidateScore(Scoring));

                scores.Add(new Score(Player, Mission, Scoring));
                
            }

            Console.WriteLine();

            Score[] ranking = Score.GenerateUniqueRanking(scores);

            Console.WriteLine("Missions with the best player rankings:");
            foreach (Score score in ranking)
            {
                Console.WriteLine();
                Console.WriteLine(score.Player + " " + score.Mission + " " + score.Scoring);
            }

        }
    }
}
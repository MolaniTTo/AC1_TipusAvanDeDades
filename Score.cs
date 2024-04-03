using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AC1Score
{
    public class Score
    {
        public string Player { get; set; }
        public string Mission { get; set; }
        public int Scoring { get; set; }

       

        public Score(string player, string mission, int scoring)
        {
            Player = player;
            Mission = mission;
            Scoring = scoring;
        }

        public static Score[] GenerateUniqueRanking(List<Score> scores)
        {
            var uniqueScores = scores
                .GroupBy(score => new { score.Player, score.Mission })
                .Select(group => group.OrderByDescending(score => score.Scoring).First())
                .OrderByDescending(score => score.Scoring)
                .ToArray();

            return uniqueScores;
        }

    }
}
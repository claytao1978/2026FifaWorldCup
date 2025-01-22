using FifaWorldCup.Interfaces;

namespace FifaWorldCup.Models
{
    public class Match(int id, Team team1, Team team2, int team1Score, int team2Score,int timeelapsed ,bool isFinished) : IMatch
    {
        public int TimeElapsed { get; set; } = timeelapsed;
        public int ID { get; set; } = id;
        public Team Team1 { get; set; } = team1;
        public Team Team2 { get; set; } = team2;
        public int Team1Score { get; set; } = team1Score;
        public int Team2Score { get; set; } = team2Score;
        public bool IsFinished { get; set; } = isFinished;

    }
}

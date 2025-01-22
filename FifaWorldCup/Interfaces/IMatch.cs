using FifaWorldCup.Models;

namespace FifaWorldCup.Interfaces
{
    public interface IMatch
    {
        public int ID { get; set; }
        public int TimeElapsed { get; set; }
        bool IsFinished { get; set; }
        Team Team1 { get; set; }
        int Team1Score { get; set; }
        Team Team2 { get; set; }
        int Team2Score { get; set; }
    }
}
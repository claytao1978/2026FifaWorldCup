using FifaWorldCup.Interfaces;

namespace FifaWorldCup.Models
{
    public class FootballMatch : IFootballMatch
    {
        public FootballMatch(List<Match> matches)
        {
            Matches = matches;
        }

        public List<Match> Matches { get; set; } = null!;
    }
}

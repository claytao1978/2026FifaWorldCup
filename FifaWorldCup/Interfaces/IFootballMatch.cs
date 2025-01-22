using FifaWorldCup.Models;

namespace FifaWorldCup.Interfaces
{
    public interface IFootballMatch
    {
        List<Match> Matches { get; set; }
    }
}
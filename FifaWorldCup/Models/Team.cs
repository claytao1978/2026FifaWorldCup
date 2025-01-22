using FifaWorldCup.Interfaces;

namespace FifaWorldCup.Models
{
    public class Team : ITeam
    {
        public Team(int id, string name, int points)
        {
            ID = id;
            Name = name;
            Points = points;
        }

       public int ID { get; set; }
       public string Name { get; set; } = string.Empty;
       public int Points { get; set; }
    }
}

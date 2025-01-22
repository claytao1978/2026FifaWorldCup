namespace FifaWorldCup.Interfaces
{
    public interface ITeam
    {
        public int ID { get; set; }
        string Name { get; set; }
        int Points { get; set; }
    }
}
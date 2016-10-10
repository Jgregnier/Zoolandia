namespace Zoolandia.Interfaces
{
    public interface IForestHabitat
    {
        string trimTrees();
        int normalTemp { get; set; }
        double squareFeet { get; set; }
    }

    public interface ISwampHabitat
    {
        string creepyBubbles();
        int waterTemp { get; set; }
        int waterViscosity { get; set; }
    }
}

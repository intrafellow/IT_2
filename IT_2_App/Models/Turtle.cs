namespace IT_2_App.Models;

public class Turtle : Creature
{
    public Turtle(double maxSpeed, double speedStep) : base(maxSpeed, speedStep)
    {
    }

    public override string GetInfo()
    {
        return $"Turtle - {base.GetInfo()}";
    }
} 
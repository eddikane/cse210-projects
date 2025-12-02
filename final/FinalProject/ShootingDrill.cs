public class ShootingDrill : TrainingDrill
{
    public ShootingDrill() : base("Do 20 shooting repetitions.")
    {

    }

    public override string PerformDrill()
    {
        return _description;
    }
}

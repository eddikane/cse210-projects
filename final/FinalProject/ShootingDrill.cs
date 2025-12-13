public class ShootingDrill : TrainingDrill
{
    public ShootingDrill() 
        : base("Perform 20 shooting repetitions focusing on accuracy.")
    {

    }

    public override string PerformDrill()
    {
        return _description;
    }
}

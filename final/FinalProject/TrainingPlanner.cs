using System.Collections.Generic;

public class TrainingPlanner
{
    public List<TrainingDrill> GeneratePlan(Player player)
    {
        List<TrainingDrill> drills = new List<TrainingDrill>();

        drills.Add(new ShootingDrill());

        return drills;
    }
}

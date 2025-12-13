using System.Collections.Generic;

public class TrainingPlanner
{
    public List<TrainingDrill> GeneratePlan(Player player)
    {
        List<TrainingDrill> drills = new List<TrainingDrill>();

        string weakness = player.GetWeaknesses();

        // All players get at least one shooting drill
        drills.Add(new ShootingDrill());

        // If the player is a midfielder or defender, add a passing drill
        if (weakness.Contains("passing") || weakness.Contains("position"))
        {
            drills.Add(new PassingDrill());
        }

        return drills;
    }
}

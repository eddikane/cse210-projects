public class Match
{
    public int Goals;
    public int Assists;
    public int PassesCompleted;
    public int PassesAttempted;

    public Match(int goals, int assists, int pc, int pa)
    {
        Goals = goals;
        Assists = assists;
        PassesCompleted = pc;
        PassesAttempted = pa;
    }

    public double GetPassAccuracy()
    {
        if (PassesAttempted == 0) return 0;

        return (double)PassesCompleted / (double)PassesAttempted * 100;
    }
}


public class Midfielder : Player
{
    public Midfielder(string name, int age) : base(name, age, "Midmidfielder")
    {

    }

    public override string GetWeaknesses()
    {
        return "Needs to improve passing consistency.";
    }
}

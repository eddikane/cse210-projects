public class Midfielder : Player
{
    public Midfielder(string name, int age) : base(name, age, "Midfielder")
    {

    }

    public override string GetWeaknesses()
    {
        return "Needs to improve passing consistency.";
    }
}

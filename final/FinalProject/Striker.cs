public class Striker : Player
{
    public Striker(string name, int age) : base(name, age, "Striker")
    {

    }

    public override string GetWeaknesses()
    {
        return "Needs to improve shooting accuracy.";
    }
}

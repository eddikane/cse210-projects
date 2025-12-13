public class Defender : Player
{
    public Defender(string name, int age) : base(name, age, "Defender")
    {

    }

    public override string GetWeaknesses()
    {
        return "Should work on positioning and timing.";
    }
}

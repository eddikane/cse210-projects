public abstract class TrainingDrill
{
    protected string _description;

    public TrainingDrill(string description)
    {
        _description = description;
    }

    public virtual string PerformDrill()
    {
        return _description;
    }
}

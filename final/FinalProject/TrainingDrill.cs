public abstract class TrainingDrill
{
    protected string _description;

    public TrainingDrill(string desc)
    {
        _description = desc;
    }

    public virtual string PerformDrill()
    {
        return _description;
    }
}

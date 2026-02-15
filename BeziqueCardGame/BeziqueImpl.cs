namespace BeziqueCardGame;

public partial class BeziqueBrain
{
    internal IBeziqueAdapter _adapter;

    public BeziqueBrain(IBeziqueAdapter adapter)
    {
        _adapter = adapter;
    }
}
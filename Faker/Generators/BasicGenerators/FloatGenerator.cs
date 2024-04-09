namespace DTOFiller;

public class FloatGenerator : IGenerator
{
    static Random rng = new();
    static IntGenerator  intGen = new();
    public object Get()
    {
        return rng.NextSingle() * (int)intGen.Get();
    }
}

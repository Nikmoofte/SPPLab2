namespace DTOFiller;

public class DoubleGenerator : IGenerator
{
    static Random rng = new();
    static IntGenerator longGen = new();
    public object Get()
    {
        return rng.NextDouble() * (long)longGen.Get();
    }
}

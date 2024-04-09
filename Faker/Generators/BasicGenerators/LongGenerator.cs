namespace DTOFiller;

public class LongGenerator : IGenerator
{
    static Random rand = new Random();
    public object Get()
    {
        return rand.NextInt64();
    }
}

namespace DTOFiller;

public class DecimalGenerator : IGenerator
{
    static Random rng = new Random();
    private static int NextInt32()
    {
        int firstBits = rng.Next(0, 1 << 4) << 28;
        int lastBits = rng.Next(0, 1 << 28);
        return firstBits | lastBits;
    }

    private static decimal NextDecimal()
    {
        byte scale = (byte) rng.Next(29);
        bool sign = rng.Next(2) == 1;
        return new decimal(NextInt32(), 
                           NextInt32(),
                           NextInt32(),
                           sign,
                           scale);
    }

    public object Get()
    {
        return NextDecimal();
    }
}

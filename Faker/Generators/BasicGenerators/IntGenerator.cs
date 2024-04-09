using System.Numerics;

namespace DTOFiller;

public class IntGenerator : IGenerator
{
    static Random rng = new Random();
    private static int NextInt32()
    {
        int firstBits = rng.Next(0, 1 << 4) << 28;
        int lastBits = rng.Next(0, 1 << 28);
        return firstBits | lastBits;
    }
    public object Get()
    {
        return NextInt32();
    }
}

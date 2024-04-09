namespace DTOFiller;

public class ByteGenerator : IGenerator
{
    static Random rng = new();

    public object Get()
    {
        byte[] arr = new byte[1];
        rng.NextBytes(arr);
        return arr[0];
    }
}

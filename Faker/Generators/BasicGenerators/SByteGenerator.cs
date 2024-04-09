namespace DTOFiller;

public class SByteGenerator : IGenerator
{
    static ByteGenerator bg = new(); 
    public object Get()
    {
        return (sbyte)bg.Get();
    }
}

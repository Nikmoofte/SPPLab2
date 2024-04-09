namespace DTOFiller;

public class CharGenerator : IGenerator
{
    static ByteGenerator bg = new(); 
    public object Get()
    {
        return (char)bg.Get();
    }

}

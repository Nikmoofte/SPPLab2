namespace DTOFiller;

public class BoolGenerator : IGenerator
{
    static Random rng = new Random();
    public object Get()
    {
        return rng.Next(2) == 1;
    }


}

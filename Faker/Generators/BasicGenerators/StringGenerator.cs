namespace DTOFiller;

public class StringGenerator : IGenerator
{
    static Random rng = new();
    const int baseLength = 10;
    public object Get()
    {
        return Get(baseLength);
    }
    static public string Get(int length)
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        return new string(Enumerable.Repeat(chars, length)
                        .Select(s => s[rng.Next(s.Length)]).ToArray());
    }
}

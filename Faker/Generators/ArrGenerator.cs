namespace DTOFiller;

public class ArrGenerator<T> : IGenerator
{
    const int baseLength = 10;
    static Type BaseType = typeof(T);
    public object Get()
    {
        return Get(baseLength, BaseType);
    }
    public System.Array Get(int length, Type elementType)
    {
        var array = Array.CreateInstance(elementType, length);
        var faker = new Faker();
        for (int i = 0; i < length; i++)
        {
            array.SetValue(faker.Generate(elementType), i);
        }
        return array;
    }

}

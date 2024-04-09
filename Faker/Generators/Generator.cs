namespace DTOFiller;

public class Generator : IGenerator
{
    public Generator()
    {
        generatorMap = new Dictionary<Type, IGenerator>
        {
            { typeof(string), new StringGenerator() },
            { typeof(int), new IntGenerator() },
            { typeof(long), new LongGenerator() },
            { typeof(double), new DoubleGenerator() },
            { typeof(float), new FloatGenerator() },
            { typeof(bool), new BoolGenerator() },
            { typeof(char), new CharGenerator() },
            { typeof(byte), new ByteGenerator() },
            { typeof(short), new SByteGenerator() },
            { typeof(Array), new ArrGenerator() },
            { typeof(DateTime), new DateTimeGenerator() }
        };
    }
    public object Get()
    {
        return new object();
    } 
    public object? Get(Type valType)
    {
        if(generatorMap.ContainsKey(valType))
            return generatorMap[valType].Get();
        else
            return null;
    }

    Dictionary<Type, IGenerator> generatorMap;

}

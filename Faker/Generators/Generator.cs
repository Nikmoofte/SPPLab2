using System.ComponentModel;

namespace DTOFiller;

public class Generator : IGenerator
{
    public Generator()
    {
        generatorMap = new Dictionary<Type, IGenerator>
        {
            { typeof(string), new StringGenerator() },
            { typeof(int), new IntGenerator() },
            { typeof(uint), new IntGenerator()},
            { typeof(ulong), new LongGenerator()},
            { typeof(long), new LongGenerator() },
            { typeof(double), new DoubleGenerator() },
            { typeof(float), new FloatGenerator() },
            { typeof(bool), new BoolGenerator() },
            { typeof(char), new CharGenerator() },
            { typeof(byte), new ByteGenerator() },
            { typeof(short), new SByteGenerator() },
            { typeof(Array), new ArrGenerator<object>() },
            { typeof(int[]), new ArrGenerator<int>() },
            { typeof(uint[]), new ArrGenerator<uint>() },
            { typeof(ulong[]), new ArrGenerator<ulong>() },
            { typeof(long[]), new ArrGenerator<long>() },
            { typeof(double[]), new ArrGenerator<double>() },
            { typeof(float[]), new ArrGenerator<float>() },
            { typeof(bool[]), new ArrGenerator<bool>() },
            { typeof(char[]), new ArrGenerator<char>() },
            { typeof(byte[]), new ArrGenerator<byte>() },
            { typeof(short[]), new ArrGenerator<short>() },
            { typeof(string[]), new ArrGenerator<string>() },
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
    public void Add(Type key, IGenerator val)
    {
        generatorMap.Add(key, val);
    }

    Dictionary<Type, IGenerator> generatorMap;

}

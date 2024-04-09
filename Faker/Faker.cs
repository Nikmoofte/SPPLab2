
using System.Reflection;

namespace DTOFiller
{
    public class Faker
    {
        public Faker()
        {

        }
        public T? Create<T>()
        {
            Type objType = typeof(T); 

            T newObj = (T)generator.Get(objType);

            if(newObj == null)
            {
                FieldInfo[] info = objType.GetFields();
                PropertyInfo[] propertyInfo = objType.GetProperties();
                List<Field> fields = new List<Field>();
                List<Property> properties = new List<Property>();
                // Display the Result 
                for (int i = 0; i < info.Length; i++) 
                {
                    Type type = info[i].FieldType;
                    MethodInfo create = this.GetType().GetMethod("Create") ?? throw new Exception("Generics suck");
                    create = create.MakeGenericMethod(type);
                    fields.Add(new Field(info[i].Name, create.Invoke(this, null), type));
                }
                for (int i = 0; i < propertyInfo.Length; i++)
                {
                    Type type = propertyInfo[i].PropertyType;
                    MethodInfo create = this.GetType().GetMethod("Create") ?? throw new Exception("Generics suck");
                    create = create.MakeGenericMethod(type);
                    properties.Add(new Property(propertyInfo[i].Name, create.Invoke(this, null), type));
                }

                newObj = DTOTypeBuilder.CreateNewObject<T>(fields, properties);
            }
            return newObj;
        }
        public object? Generate(Type valType)
        {
            return generator.Get(valType);
        }
        void AddConfig<InType, OutType>(Func<InType, OutType> func, IGenerator generator)
        {

        }

        Dictionary<Type, Dictionary<FieldInfo, IGenerator>> configsFields;
        Dictionary<Type, Dictionary<PropertyInfo, IGenerator>> configsProperties;
        private Generator generator = new Generator();
    }
}
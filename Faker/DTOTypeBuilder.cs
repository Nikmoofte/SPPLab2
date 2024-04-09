namespace DTOFiller;
using System.Reflection;
using System.Reflection.Emit;
using Microsoft.VisualBasic.FileIO;

internal struct Field
{
    internal Field(string fieldName, object val, Type type)
    {
        this.fieldName = fieldName;
        fieldType = type;
        value = val;
    }
    internal string fieldName { get; }
    internal Type fieldType { get; }
    internal object value { get; }
}
internal struct Property
{
    internal Property(string fieldName, object val, Type type)
    {
        this.name = fieldName;
        this.type = type;
        value = val;
    }
    internal string name { get; }
    internal Type type { get; }
    internal object value { get; }
}

internal static class DTOTypeBuilder
{
    internal static T CreateNewObject<T>(List<Field> listOfFields, List<Property> properties)
    {
        var type = typeof(T);
        var flags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
        var constructor = type.GetConstructor(flags, null, Type.EmptyTypes, null) ?? throw new Exception("No constructor");
        var obj = (T)constructor.Invoke(null);
        var objInfo = obj.GetType();

        foreach (var field in listOfFields)
        {
            FieldInfo fi = objInfo.GetField(field.fieldName);
            fi.SetValue(obj, field.value);
        }
        foreach (var property in properties)
        {
            PropertyInfo fi = objInfo.GetProperty(property.name);
            fi.SetValue(obj, property.value);
        }

        return obj;
    }
}

using TypeGen.Core.Converters;

namespace TypeGenInheritanceWithGenerics;

public class FormatTypeName : ITypeNameConverter
{
    public string Convert(string name, Type type)
    {
        return name;
    }
}

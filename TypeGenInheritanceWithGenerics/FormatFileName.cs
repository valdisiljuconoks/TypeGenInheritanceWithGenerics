using TypeGen.Core.Converters;

namespace TypeGenInheritanceWithGenerics;

public class FormatFileName : ITypeNameConverter
{
    public string Convert(string name, Type type)
    {
        return $"{name}.generated";
    }
}

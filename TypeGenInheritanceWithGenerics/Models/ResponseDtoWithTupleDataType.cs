using TypeGen.Core.TypeAnnotations;

namespace TypeGenInheritanceWithGenerics.Models;

[ExportTsInterface]
public class ResponseDtoWithTupleDataType
{
    public Tuple<string, decimal>[] SomeDataPoints { get; set; }
}
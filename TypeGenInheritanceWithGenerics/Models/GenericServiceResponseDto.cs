using TypeGen.Core.TypeAnnotations;

namespace TypeGenInheritanceWithGenerics.Models;

[ExportTsInterface]
public abstract class GenericServiceResponseDto<T>
{
    [TsOptional]
    public T? Data { get; set; }
}
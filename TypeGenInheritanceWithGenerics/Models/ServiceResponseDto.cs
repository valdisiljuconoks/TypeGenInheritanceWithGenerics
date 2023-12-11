using TypeGen.Core.TypeAnnotations;

namespace TypeGenInheritanceWithGenerics.Models;

[ExportTsInterface]
public abstract class ServiceResponseDto
{
    [TsOptional]
    public DateTimeOffset Timestamp { get; set; }
}
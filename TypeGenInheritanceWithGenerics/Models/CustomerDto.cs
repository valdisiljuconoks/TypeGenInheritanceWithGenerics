using TypeGen.Core.TypeAnnotations;

namespace TypeGenInheritanceWithGenerics.Models;

[ExportTsInterface]
public class CustomerDto
{
    public DateTime CreatedAt { get; set; }
}
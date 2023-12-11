using TypeGen.Core.TypeAnnotations;

namespace TypeGenInheritanceWithGenerics.Models;

[ExportTsInterface]
public class GetCustomersResponseDto : GenericServiceResponseDto<CustomerDto?>
{
}
using commercetools.Api.Models.Types;

namespace commercetools.Api.Serialization.Mappers.CustomFieldMappers
{
    internal class NumberFieldMapper : NumberConverter<FieldContainer, double>, ICustomJsonMapper<FieldContainer>
    {
    }
}
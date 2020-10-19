using commercetools.Api.Models.Types;
using commercetools.Base.Serialization.Mappers;

namespace commercetools.Api.Serialization.Mappers.CustomFieldMappers
{
    class NumberFieldMapper : NumberConverter<FieldContainer, double>, ICustomJsonMapper<FieldContainer>
    {
    }
}
using commercetools.Api.Models.Types;
using commercetools.Base.Serialization.Mappers;

namespace commercetools.Sdk.Api.Serialization.Mappers.CustomFieldMappers
{
    class NumberFieldMapper : NumberConverter<IFieldContainer, double>, ICustomJsonMapper<IFieldContainer>
    {
    }
}
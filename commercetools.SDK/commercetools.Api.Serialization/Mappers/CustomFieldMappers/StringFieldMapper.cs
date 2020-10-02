using commercetools.Api.Models.Types;

namespace commercetools.Api.Serialization.Mappers.CustomFieldMappers
{
    internal class StringFieldMapper : StringConverter<FieldContainer, string>, ICustomJsonMapper<FieldContainer>
    {
    }
}
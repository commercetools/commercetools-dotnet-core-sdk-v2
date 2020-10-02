using System.Collections.Generic;
using commercetools.Api.Models.Types;
using commercetools.Api.Serialization.Mappers;

namespace commercetools.Api.Serialization.MapperTypeRetrievers
{
    internal class FieldMapperTypeRetriever : MapperTypeRetriever<FieldContainer>
    {
        public FieldMapperTypeRetriever(IEnumerable<ICustomJsonMapper<FieldContainer>> customJsonMappers) : base(customJsonMappers)
        {
        }
    }
}
using System.Collections.Generic;
using commercetools.Api.Models.Types;
using commercetools.Base.Serialization.Mappers;
using commercetools.Base.Serialization.MapperTypeRetrievers;

namespace commercetools.Sdk.Api.Serialization.MapperTypeRetrievers
{
    public class FieldMapperTypeRetriever : MapperTypeRetriever<IFieldContainer>
    {
        public FieldMapperTypeRetriever(IEnumerable<ICustomJsonMapper<IFieldContainer>> customJsonMappers) : base(customJsonMappers)
        {
        }
    }
}
using System.Collections.Generic;
using commercetools.Api.Models.Types;
using commercetools.Base.Serialization.Mappers;
using commercetools.Base.Serialization.MapperTypeRetrievers;

namespace commercetools.Api.Serialization.MapperTypeRetrievers
{
    public class FieldMapperTypeRetriever : MapperTypeRetriever<FieldContainer>
    {
        public FieldMapperTypeRetriever(IEnumerable<ICustomJsonMapper<FieldContainer>> customJsonMappers) : base(customJsonMappers)
        {
        }
    }
}
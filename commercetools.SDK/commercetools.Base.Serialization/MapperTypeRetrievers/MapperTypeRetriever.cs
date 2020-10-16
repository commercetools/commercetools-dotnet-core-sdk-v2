using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using commercetools.Base.Serialization.Mappers;

namespace commercetools.Base.Serialization.MapperTypeRetrievers
{
    public abstract class MapperTypeRetriever<T> : IMapperTypeRetriever<T>
    {
        private readonly IEnumerable<ICustomJsonMapper<T>> customJsonMappers;

        public MapperTypeRetriever(IEnumerable<ICustomJsonMapper<T>> customJsonMappers)
        {
            this.customJsonMappers = customJsonMappers;
        }

        public virtual Type GetTypeForToken(JsonElement element)
        {
            return this.GetTypeForTokenFromMapper(element);
        }

        protected Type GetTypeForTokenFromMapper(JsonElement element)
        {
            foreach (var customJsonMapper in this.customJsonMappers.OrderBy(c => c.Priority))
            {
                if (customJsonMapper.CanConvert(element))
                {
                    return customJsonMapper.Type;
                }
            }
            return null;
        }
    }
}
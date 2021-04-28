using System;
using System.Text.Json;

namespace commercetools.Base.Serialization.MapperTypeRetrievers
{
    public abstract class MapperTypeRetriever<T> : IMapperTypeRetriever<T>
    {
        public virtual Type GetTypeForToken(JsonElement element)
        {
            return typeof(object);
        }
    }
}
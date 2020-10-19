using System;
using System.Text.Json;

namespace commercetools.Base.Serialization.MapperTypeRetrievers
{
    public interface IMapperTypeRetriever<T>
    {
        Type GetTypeForToken(JsonElement element);
    }
}
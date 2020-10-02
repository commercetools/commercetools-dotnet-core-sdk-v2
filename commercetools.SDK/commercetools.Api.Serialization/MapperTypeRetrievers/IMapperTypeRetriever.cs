using System;
using System.Text.Json;

namespace commercetools.Api.Serialization.MapperTypeRetrievers
{
    public interface IMapperTypeRetriever<T>
    {
        Type GetTypeForToken(JsonElement element);
    }
}
using System;
using System.Text.Json;

namespace commercetools.Base.Serialization.Mappers
{
    public interface ICustomJsonMapper<T>
    {
        bool CanConvert(JsonElement property);

        int Priority { get; }
        Type Type { get; }
    }
}
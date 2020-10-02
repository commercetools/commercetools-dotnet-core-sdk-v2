using System;
using System.Text.Json;

namespace commercetools.Api.Serialization.Mappers
{
    internal abstract class NumberConverter<T, S> : ICustomJsonMapper<T>
    {
        public int Priority => 4;

        public Type Type => typeof(S);

        public bool CanConvert(JsonElement property)
        {
            return property.ValueKind == JsonValueKind.Number;
        }
    }
}
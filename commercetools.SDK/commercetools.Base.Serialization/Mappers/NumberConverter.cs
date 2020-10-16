using System;
using System.Text.Json;

namespace commercetools.Base.Serialization.Mappers
{
    public abstract class NumberConverter<T, S> : ICustomJsonMapper<T>
    {
        public int Priority => 4;

        public Type Type => typeof(S);

        public bool CanConvert(JsonElement property)
        {
            return property.ValueKind == JsonValueKind.Number;
        }
    }
}
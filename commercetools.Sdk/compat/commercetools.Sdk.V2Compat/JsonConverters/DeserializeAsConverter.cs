using System;
using System.Reflection;
using commercetools.Base.CustomAttributes;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace commercetools.Sdk.V2Compat.JsonConverters
{
    public class DeserializeAsConverter<T> : JsonConverter
    {
        public override bool CanConvert(Type typeToConvert)
        {
            return (typeToConvert.IsAbstractClass() || typeToConvert.IsInterface)
                   && typeToConvert.IsDefined(typeof(DeserializeAsAttribute));
        }
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var deserializeAsAttribute = typeof(T).GetCustomAttribute<DeserializeAsAttribute>();
            if (deserializeAsAttribute == null)
                throw new NullReferenceException($"Failed to find the required '{nameof(DeserializeAsAttribute)}'");

            var deserializedType = deserializeAsAttribute.DeserializedType;
            var jsonObject = JObject.Load(reader);
            return jsonObject.ToObject(deserializedType, serializer);
        }
        
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
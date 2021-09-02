using System;
using System.Collections.Concurrent;
using System.Reflection;
using commercetools.Base.CustomAttributes;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace commercetools.Sdk.V2Compat.JsonConverters
{
    public class TypeDiscriminatorConverter<T> : JsonConverter
    {
        private readonly PropertyInfo _discriminatorProperty;
        protected ConcurrentDictionary<string, Type> _subTypes;

        public TypeDiscriminatorConverter()
        {
            var discriminatorAttribute = typeof(T).GetCustomAttribute<TypeDiscriminatorAttribute>();
            if (discriminatorAttribute == null)
                throw new NullReferenceException($"Failed to find the required '{nameof(TypeDiscriminatorAttribute)}'");
            this._discriminatorProperty = typeof(T).GetProperty(discriminatorAttribute.Property,
                BindingFlags.Default | BindingFlags.Public | BindingFlags.Instance);
            if (this._discriminatorProperty == null)
                throw new NullReferenceException(
                    $"Failed to find the specified discriminator property '{discriminatorAttribute.Property}' in type '{typeof(T).Name}'");

            var subTypesAttrs = typeof(T).GetCustomAttributes<SubTypeDiscriminatorAttribute>();
            _subTypes = new ConcurrentDictionary<string, Type>();
            foreach (var attr in subTypesAttrs)
            {
                _subTypes.TryAdd(attr.Value, attr.SubType);
            }
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JObject jsonObject = JObject.Load(reader);
            var discriminatorPropertyName = this._discriminatorProperty.Name.ToCamelCase();
            // JToken discriminatorValue;
            if (!jsonObject.TryGetValue(discriminatorPropertyName, out JToken discriminatorValue))
            {
                throw new JsonException($"Failed to find the required '{this._discriminatorProperty.Name}' discriminator property");
            }
            if (!this._subTypes.TryGetValue(discriminatorValue?.ToString() ?? "", out Type derivedType))
            {
                throw new JsonException($"Failed to find the derived type with the specified discriminator value '{discriminatorValue}'");
            }
            return jsonObject.ToObject(derivedType, serializer);
        }

        /// <inheritdoc/>
        public override bool CanConvert(Type typeToConvert)
        {
            return typeToConvert.IsClass && typeToConvert.IsAbstract && typeToConvert.IsDefined(typeof(TypeDiscriminatorAttribute));
        }
    }
}
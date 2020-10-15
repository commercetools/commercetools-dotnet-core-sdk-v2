using System;
using System.Collections.Generic;
using System.Reflection;
using commercetools.Base.Abstractions.CustomAttributes;
using commercetools.Api.Serialization;
using commercetools.Sdk.Registration;
using commercetools.Sdk.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace commercetools.Sdk.V2Compat
{
    public class DiscriminatorConverter<T> : JsonConverter
    {
        private readonly PropertyInfo _discriminatorProperty;
        private readonly Dictionary<string, Type> _typeMappings;
        
        public DiscriminatorConverter(ITypeRetriever typeRetriever)
        {
            DiscriminatorAttribute discriminatorAttribute = typeof(T).GetCustomAttribute<DiscriminatorAttribute>();
            if (discriminatorAttribute == null)
                throw new NullReferenceException($"Failed to find the required '{nameof(DiscriminatorAttribute)}'");
            this._discriminatorProperty = typeof(T).GetProperty(discriminatorAttribute.Property,
                BindingFlags.Default | BindingFlags.Public | BindingFlags.Instance);
            if (this._discriminatorProperty == null)
                throw new NullReferenceException(
                    $"Failed to find the specified discriminator property '{discriminatorAttribute.Property}' in type '{typeof(T).Name}'");
            this._typeMappings = new Dictionary<string, Type>();
            var derivedTypes = typeRetriever.GetTypes<T>();

            foreach (var derivedType in derivedTypes)
            {
                var discriminatorValueAttribute = derivedType.GetCustomAttribute<DiscriminatorValueAttribute>();
                if (discriminatorValueAttribute == null)
                    continue;
                var discriminatorValue = discriminatorValueAttribute.Value.ToString();
                this._typeMappings.Add(discriminatorValue, derivedType);
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
            if (!this._typeMappings.TryGetValue(discriminatorValue?.ToString() ?? "", out Type derivedType))
            {
                throw new JsonException($"Failed to find the derived type with the specified discriminator value '{discriminatorValue}'");
            }
            return jsonObject.ToObject(derivedType, serializer);
        }

        /// <inheritdoc/>
        public override bool CanConvert(Type typeToConvert)
        {
            return typeToConvert.IsClass && typeToConvert.IsAbstract && typeToConvert.IsDefined(typeof(DiscriminatorAttribute));
        }
    }
}
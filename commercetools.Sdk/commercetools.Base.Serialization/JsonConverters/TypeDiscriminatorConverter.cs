using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using commercetools.Base.Registration;
using commercetools.Base.CustomAttributes;

namespace commercetools.Base.Serialization.JsonConverters
{
    public class TypeDiscriminatorConverter<T>
        : JsonConverter<T>
    {
        public TypeDiscriminatorConverter(JsonNamingPolicy namingPolicy, JsonSerializerOptions jsonSerializerOptions)
        {
            this.NamingPolicy = namingPolicy;
            this.JsonSerializerOptions = jsonSerializerOptions;
            
            DiscriminatorAttribute = typeof(T).GetCustomAttribute<TypeDiscriminatorAttribute>();
            if (DiscriminatorAttribute == null)
                throw new NullReferenceException($"Failed to find the required '{nameof(TypeDiscriminatorAttribute)}'");
            this.DiscriminatorProperty = typeof(T).GetProperty(DiscriminatorAttribute.Property,
                BindingFlags.Default | BindingFlags.Public | BindingFlags.Instance);
            if (this.DiscriminatorProperty == null)
                throw new NullReferenceException(
                    $"Failed to find the specified discriminator property '{DiscriminatorAttribute.Property}' in type '{typeof(T).Name}'");
            
            var defaultTypeAttr = typeof(T).GetCustomAttribute<DefaultTypeDiscriminatorAttribute>();
            DefaultType = defaultTypeAttr?.DefaultType;
            var subTypesAttrs = typeof(T).GetCustomAttributes<SubTypeDiscriminatorAttribute>();
            SubTypes = new Dictionary<string, Type>();
            foreach (var attr in subTypesAttrs)
            {
                SubTypes.Add(attr.Value, attr.SubType);
            }
        }
        
        protected JsonNamingPolicy NamingPolicy { get; }
        
        protected TypeDiscriminatorAttribute DiscriminatorAttribute { get; }
        
        protected JsonSerializerOptions JsonSerializerOptions { get; }
        
        protected PropertyInfo DiscriminatorProperty { get; }
        
        protected Dictionary<string, Type> SubTypes { get; }
        
        protected Type DefaultType { get; }
        
        /// <inheritdoc/>
        public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartObject)
                throw new JsonException("Start object token type expected");
            using JsonDocument jsonDocument = JsonDocument.ParseValue(ref reader);
            var discriminatorPropertyName = this.NamingPolicy?.ConvertName(this.DiscriminatorProperty.Name);
            if (!jsonDocument.RootElement.TryGetProperty(discriminatorPropertyName,
                out JsonElement discriminatorProperty))
                throw new JsonException(
                    $"Failed to find the required '{this.DiscriminatorProperty.Name}' discriminator property");
            var discriminatorValue = discriminatorProperty.GetString();


            if (!this.SubTypes.TryGetValue(discriminatorValue, out Type derivedType))
            {
                if (DefaultType == null)
                {
                    throw new JsonException(
                        $"Failed to find ${nameof(DefaultTypeDiscriminatorAttribute)}");    
                }
                derivedType = DefaultType;
            }

            var json = jsonDocument.RootElement.GetRawText();
            return (T)JsonSerializer.Deserialize(json, derivedType, JsonSerializerOptions);
        }

        /// <inheritdoc/>
        public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, (object) value, options);
        }
    }
}
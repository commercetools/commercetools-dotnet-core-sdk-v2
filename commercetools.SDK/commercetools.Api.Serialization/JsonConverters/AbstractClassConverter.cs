using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using commercetools.Api.Registration;
using commercetools.Api.Serialization.CustomAttributes;

namespace commercetools.Api.Serialization.JsonConverters
{
    /// <summary>
    /// Represents the <see cref="JsonConverter"/> used to convert to/from an abstract class
    /// </summary>
    /// <typeparam name="T">The type of the abstract class to convert to/from</typeparam>
    public class AbstractClassConverter<T>
        : JsonConverter<T>
    {
        /// <summary>
        /// Initializes a new <see cref="AbstractClassConverter{T}"/>
        /// </summary>
        /// <param name="namingPolicy">The current <see cref="JsonNamingPolicy"/></param>
        /// <param name="typeRetriever"></param>
        public AbstractClassConverter(JsonNamingPolicy namingPolicy, ITypeRetriever typeRetriever)
        {
            this.NamingPolicy = namingPolicy;
            DiscriminatorAttribute discriminatorAttribute = typeof(T).GetCustomAttribute<DiscriminatorAttribute>();
            if (discriminatorAttribute == null)
                throw new NullReferenceException($"Failed to find the required '{nameof(DiscriminatorAttribute)}'");
            this.DiscriminatorProperty = typeof(T).GetProperty(discriminatorAttribute.Property,
                BindingFlags.Default | BindingFlags.Public | BindingFlags.Instance);
            if (this.DiscriminatorProperty == null)
                throw new NullReferenceException(
                    $"Failed to find the specified discriminator property '{discriminatorAttribute.Property}' in type '{typeof(T).Name}'");
            this.TypeMappings = new Dictionary<string, Type>();
            var derivedTypes = typeRetriever.GetTypes<T>();

            foreach (var derivedType in derivedTypes)
            {
                var discriminatorValueAttribute = derivedType.GetCustomAttribute<DiscriminatorValueAttribute>();
                if (discriminatorValueAttribute == null)
                    continue;
                var discriminatorValue = discriminatorValueAttribute.Value.ToString();
                this.TypeMappings.Add(discriminatorValue, derivedType);
            }
        }

        /// <summary>
        /// Gets the current <see cref="JsonNamingPolicy"/>
        /// </summary>
        protected JsonNamingPolicy NamingPolicy { get; }

        /// <summary>
        /// Gets the discriminator <see cref="PropertyInfo"/> of the abstract type to convert
        /// </summary>
        protected PropertyInfo DiscriminatorProperty { get; }

        /// <summary>
        /// Gets an <see cref="Dictionary{TKey, TValue}"/> containing the mappings of the converted type's derived types
        /// </summary>
        protected Dictionary<string, Type> TypeMappings { get; }

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
            if (!this.TypeMappings.TryGetValue(discriminatorValue, out Type derivedType))
                throw new JsonException(
                    $"Failed to find the derived type with the specified discriminator value '{discriminatorValue}'");
            var json = jsonDocument.RootElement.GetRawText();
            return (T) JsonSerializer.Deserialize(json, derivedType);
        }

        /// <inheritdoc/>
        public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, (object) value, options);
        }
    }
}
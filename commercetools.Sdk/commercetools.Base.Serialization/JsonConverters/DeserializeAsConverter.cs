using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using commercetools.Base.Registration;
using commercetools.Base.CustomAttributes;

namespace commercetools.Base.Serialization.JsonConverters
{
    /// <summary>
    /// Represents the <see cref="JsonConverter"/> used to convert to/from an interface
    /// </summary>
    /// <typeparam name="T">The type of the interface to convert to/from</typeparam>
    public class DeserializeAsConverter<T>
        : JsonConverter<T>
    {
        protected JsonNamingPolicy NamingPolicy { get; }

        protected JsonSerializerOptions JsonSerializerOptions { get; }

        protected Type DeserializedType { get; }

        public DeserializeAsConverter(JsonNamingPolicy namingPolicy, JsonSerializerOptions jsonSerializerOptions)
        {
            this.NamingPolicy = namingPolicy;
            this.JsonSerializerOptions = jsonSerializerOptions;

            var deserializeAsAttribute = typeof(T).GetCustomAttribute<DeserializeAsAttribute>();
            if (deserializeAsAttribute == null)
                throw new NullReferenceException($"Failed to find the required '{nameof(DeserializeAsAttribute)}'");

            DeserializedType = deserializeAsAttribute.DeserializedType;

        }

        public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartObject)
                throw new JsonException("Start object token type expected");
            return (T)JsonSerializer.Deserialize(ref reader, DeserializedType, JsonSerializerOptions);
        }

        /// <inheritdoc/>
        public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, (object)value, options);
        }
    }
}
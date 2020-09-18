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
    /// Represents the <see cref="JsonConverterFactory"/> used to create <see cref="AbstractClassConverter{T}"/>
    /// </summary>
    public class AbstractClassConverterFactory
        : JsonConverterFactory
    {

        private readonly ITypeRetriever typeRetriever; 
        /// <summary>
        /// Gets a <see cref="Dictionary{TKey,TValue}"/> containing the mappings of types to their respective <see cref="JsonConverter"/>
        /// </summary>
        protected static Dictionary<Type, JsonConverter> Converters = new Dictionary<Type, JsonConverter>();

        /// <summary>
        /// Initializes a new <see cref="AbstractClassConverterFactory"/>
        /// </summary>
        /// <param name="namingPolicy">The current <see cref="JsonNamingPolicy"/></param>
        public AbstractClassConverterFactory(JsonNamingPolicy namingPolicy, ITypeRetriever typeRetriever)
        {
            this.NamingPolicy = namingPolicy;
            this.typeRetriever = typeRetriever;
        }

        /// <summary>
        /// Gets the current <see cref="JsonNamingPolicy"/>
        /// </summary>
        protected JsonNamingPolicy NamingPolicy { get; }

        /// <inheritdoc/>
        public override bool CanConvert(Type typeToConvert)
        {
            return typeToConvert.IsClass && typeToConvert.IsAbstract && typeToConvert.IsDefined(typeof(DiscriminatorAttribute));
        }

        /// <inheritdoc/>
        public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
        {
            if(!Converters.TryGetValue(typeToConvert, out JsonConverter converter))
            {
                Type converterType = typeof(AbstractClassConverter<>).MakeGenericType(typeToConvert);
                converter = (JsonConverter)Activator.CreateInstance(converterType, this.NamingPolicy, this.typeRetriever);
                Converters.Add(typeToConvert, converter);
            }
            return converter;
        }

    }
}
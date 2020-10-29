using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using commercetools.Api.Models.Types;

using commercetools.Base.Serialization;
using commercetools.Base.Serialization.MapperTypeRetrievers;
using Type = System.Type;

namespace commercetools.Api.Serialization.JsonConverters
{
    public class FieldContainerConverter : JsonConverter<IFieldContainer>
    {
        private readonly IMapperTypeRetriever<IFieldContainer> mapperTypeRetriever;
        private ISerializerService serializerService;

        public FieldContainerConverter(IMapperTypeRetriever<IFieldContainer> mapperTypeRetriever, ISerializerService serializerService)
        {
            this.mapperTypeRetriever = mapperTypeRetriever;
            this.serializerService = serializerService;
        }


        public override IFieldContainer Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var jsonDocument = JsonDocument.ParseValue(ref reader);

            var enumerator = jsonDocument.RootElement.EnumerateObject();
            
            var fieldContainer = new FieldContainer();
            
            foreach (var jsonElement in enumerator)
            {
                string key = jsonElement.Name;
                var value = jsonElement.Value;
                Type returnType = this.mapperTypeRetriever.GetTypeForToken(value);
                if (returnType != null)
                {
                    object o =  value.ToObject(returnType, serializerService);
                    fieldContainer.Add(key, o);
                }
                else
                {
                    fieldContainer.Add(key, value);
                }
            }
            return fieldContainer;
            /*
            if (reader.TokenType != JsonTokenType.StartObject)
            {
                throw new JsonException($"JsonTokenType was of type {reader.TokenType}, only objects are supported");
            }
            
            while (reader.Read())
            {
                if (reader.TokenType == JsonTokenType.EndObject)
                {
                    return fieldContainer;
                }

                if (reader.TokenType != JsonTokenType.PropertyName)
                {
                    throw new JsonException("JsonTokenType was not PropertyName");
                }

                var propertyName = reader.GetString();

                if (string.IsNullOrWhiteSpace(propertyName))
                {
                    throw new JsonException("Failed to get property name");
                }

                reader.Read();
                
                //value

                fieldContainer.Add(propertyName, ExtractValue(ref reader, options));
            }
*/
        }

        public override void Write(Utf8JsonWriter writer, IFieldContainer value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            foreach (var item in value)
            {
                writer.WritePropertyName(item.Key);
                JsonSerializer.Serialize(writer, item.Value, options);
            }
            writer.WriteEndObject();
        }
        
        private object ExtractValue(ref Utf8JsonReader reader, JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case JsonTokenType.String:
                    if (reader.TryGetDateTime(out var date))
                    {
                        return date;
                    }
                    return reader.GetString();
                case JsonTokenType.False:
                    return false;
                case JsonTokenType.True:
                    return true;
                case JsonTokenType.Null:
                    return null;
                case JsonTokenType.Number:
                    if (reader.TryGetInt64(out var result))
                    {
                        return result;
                    }
                    return reader.GetDecimal();
                case JsonTokenType.StartObject:
                    return Read(ref reader, null, options);
                case JsonTokenType.StartArray:
                    var list = new List<object>();
                    while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
                    {
                        list.Add(ExtractValue(ref reader, options));
                    }
                    return list;
                default:
                    throw new JsonException($"'{reader.TokenType}' is not supported");
            }
        }
    }
}
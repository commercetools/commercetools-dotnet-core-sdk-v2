using System.Text.Json;
using System.Text.Json.Serialization;
using commercetools.Api.Models.Types;
using commercetools.Base.Serialization;
using commercetools.Base.Serialization.MapperTypeRetrievers;
using Type = System.Type;

namespace commercetools.Sdk.Api.Serialization.JsonConverters
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

        public override bool CanConvert(Type typeToConvert)
        {
            return typeof(IFieldContainer).IsAssignableFrom(typeToConvert);
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
                    object o = value.ToObject(returnType, serializerService);
                    fieldContainer.Add(key, o);
                }
                else
                {
                    fieldContainer.Add(key, value);
                }
            }
            return fieldContainer;
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
    }
}
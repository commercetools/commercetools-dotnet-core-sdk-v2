using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using commercetools.Sdk.Api.Models.Products;
using commercetools.Base.Serialization;
using commercetools.Base.Serialization.MapperTypeRetrievers;
using commercetools.Sdk.Api.Models.ProductSearches;
using commercetools.Sdk.Api.Serialization.MapperTypeRetrievers;
using Attribute = commercetools.Sdk.Api.Models.Products.Attribute;
using Type = System.Type;

namespace commercetools.Sdk.Api.Serialization.JsonConverters
{
    public class ProductSearchFacetConverter : JsonConverter<IProductSearchFacetResult>
    {
        private readonly ISerializerService _serializerService;

        public ProductSearchFacetConverter(ISerializerService serializerService)
        {
            this._serializerService = serializerService;
        }

        public override bool CanConvert(Type typeToConvert)
        {
            return typeof(IProductSearchFacetResult).IsAssignableFrom(typeToConvert);
        }

        public override IProductSearchFacetResult Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var jsonDocument = JsonDocument.ParseValue(ref reader);
            IAttribute attribute;
            var rootElement = jsonDocument.RootElement;
            if (rootElement.ValueKind == JsonValueKind.Object)
            {
                var nameProp = rootElement.GetProperty("name");
                if (rootElement.TryGetProperty("buckets", out var bucketsElement))
                {
                    return new ProductSearchFacetResultBucket
                    {
                        Name = nameProp.GetString(),
                        Buckets = bucketsElement.ToObject<List<IProductSearchFacetResultBucketEntry>>(_serializerService)
                    };
                }
                if (rootElement.TryGetProperty("value", out var valueElement))
                {
                    return new ProductSearchFacetResultCount
                    {
                        Name = nameProp.GetString(),
                        Value = valueElement.GetInt64()
                    };
                }

                return new ProductSearchFacetResult
                {
                    Name = nameProp.GetString()
                };
            }

            return null;
        }

        public override void Write(Utf8JsonWriter writer, IProductSearchFacetResult value,
            JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            writer.WriteString("name", value.Name);
            if (value is ProductSearchFacetResultBucket bucket)
            {
                writer.WritePropertyName("buckets");
                JsonSerializer.Serialize(writer, bucket.Buckets, options);
            }
            else if (value is ProductSearchFacetResultCount count) {
                writer.WritePropertyName("value");
                JsonSerializer.Serialize(writer, count.Value, options);
            }

            writer.WriteEndObject();
        }
    }
}
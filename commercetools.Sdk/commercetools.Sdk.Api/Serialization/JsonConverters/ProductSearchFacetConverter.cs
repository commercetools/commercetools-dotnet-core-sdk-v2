using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using commercetools.Sdk.Api.Models.Products;
using commercetools.Base.Serialization;
using commercetools.Base.Serialization.MapperTypeRetrievers;
using commercetools.Sdk.Api.Models.ProductSearches;
using commercetools.Sdk.Api.Serialization.MapperTypeRetrievers;
using Type = System.Type;

namespace commercetools.Sdk.Api.Serialization.JsonConverters
{
    public class ProductSearchFacetConverter : JsonConverter<IProductSearchFacetResult>
    {
        private readonly ISerializerService _serializerService;
        private readonly IMapperTypeRetriever<IProductSearchFacetResult> mapperTypeRetriever;
        
        public ProductSearchFacetConverter(IMapperTypeRetriever<IProductSearchFacetResult> mapperTypeRetriever, ISerializerService serializerService)
        {
            this._serializerService = serializerService;
            this.mapperTypeRetriever = mapperTypeRetriever;
        }
        
        [Obsolete("use constructor with mapperTypeRetriever instead")]
        public ProductSearchFacetConverter(ISerializerService serializerService)
        {
            this._serializerService = serializerService;
            this.mapperTypeRetriever = new ProductSearchFacetResultTypeRetriever(SerializationConfiguration.DefaultConfig);
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
                if (rootElement.TryGetProperty("sum", out var statsElement))
                {
                    var stats = new ProductSearchFacetResultStats()
                    {
                        Name = nameProp.GetString()
                    };
                    if (rootElement.TryGetProperty("min", out var min))
                    {
                        stats.Min = min.GetInt64();
                    }
                    if (rootElement.TryGetProperty("max", out var max))
                    {
                        stats.Max = max.GetInt64();
                    }
                    if (rootElement.TryGetProperty("mean", out var mean))
                    {
                        stats.Mean = mean.GetInt64();
                    }
                    if (rootElement.TryGetProperty("sum", out var sum))
                    {
                        stats.Sum = sum.GetInt64();
                    }
                    if (rootElement.TryGetProperty("count", out var count))
                    {
                        stats.Count = count.GetInt64();
                    }
                    return stats;
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
            else if (value is ProductSearchFacetResultCount count)
            {
                writer.WritePropertyName("value");
                JsonSerializer.Serialize(writer, count.Value, options);
            }

            writer.WriteEndObject();
        }
    }
}
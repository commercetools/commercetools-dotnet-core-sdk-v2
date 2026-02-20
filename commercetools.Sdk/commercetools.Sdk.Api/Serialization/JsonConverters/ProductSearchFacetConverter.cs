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
                if (rootElement.TryGetProperty("count", out var statsElement))
                {
                    var stats = new ProductSearchFacetResultStats()
                    {
                        Name = nameProp.GetString()
                    };
                    if (rootElement.TryGetProperty("min", out var min))
                    {
                        if (min.ValueKind == JsonValueKind.String)
                            stats.Min = min.GetString();
                        else if (min.IsLongOrInt())
                            stats.Min = min.GetInt64();
                        else
                            stats.Min = min.GetDecimal();
                    }
                    if (rootElement.TryGetProperty("max", out var max))
                    {
                        if (max.ValueKind == JsonValueKind.String)
                            stats.Max = max.GetString();
                        else if (max.IsLongOrInt())
                            stats.Max = max.GetInt64();
                        else
                            stats.Max = max.GetDecimal();
                    }
                    if (rootElement.TryGetProperty("mean", out var mean))
                    {
                        if (mean.ValueKind == JsonValueKind.String)
                            stats.Mean = mean.GetString();
                        else if (mean.IsLongOrInt())
                            stats.Mean = mean.GetInt64();
                        else
                            stats.Mean = mean.GetDecimal();
                    }
                    if (rootElement.TryGetProperty("sum", out var sum))
                    {
                        if (sum.ValueKind == JsonValueKind.String)
                            stats.Sum = sum.GetString();
                        else if (sum.IsLongOrInt())
                            stats.Sum = sum.GetInt64();
                        else
                            stats.Sum = sum.GetDecimal();
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
            else if (value is ProductSearchFacetResultStats stats)
            {
                if (stats.Min != null)
                {
                    writer.WritePropertyName("min");
                    JsonSerializer.Serialize(writer, stats.Min, options);
                }

                if (stats.Max != null)
                {
                    writer.WritePropertyName("max");
                    JsonSerializer.Serialize(writer, stats.Max, options);
                }

                if (stats.Mean != null)
                {
                    writer.WritePropertyName("mean");
                    JsonSerializer.Serialize(writer, stats.Mean, options);
                }

                if (stats.Sum != null)
                {
                    writer.WritePropertyName("sum");
                    JsonSerializer.Serialize(writer, stats.Sum, options);
                }

                if (stats.Count != null)
                {
                    writer.WritePropertyName("count");
                    JsonSerializer.Serialize(writer, stats.Count, options);
                }
            }

            writer.WriteEndObject();
        }
    }
}
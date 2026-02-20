using System;
using System.IO;
using commercetools.Sdk.Api.Extensions;
using commercetools.Sdk.Api.Models.ProductSearches;
using Xunit;
using commercetools.Base;

namespace commercetools.Api.Serialization.Tests
{
    public class ProductSearchDeserializationTest : IClassFixture<SerializationFixture>
    {
        private readonly SerializationFixture _serializationFixture;

        public ProductSearchDeserializationTest(SerializationFixture serializationFixture)
        {
            this._serializationFixture = serializationFixture;
        }

        [Fact]
        public void FacetDeserialization()
        {
            var serializerService = this._serializationFixture.SerializerService;
            var serialized = File.ReadAllText("Resources/ProductSearch/facets.json");
            var deserialized = serializerService.Deserialize<IProductPagedSearchResponse>(serialized);
            Assert.NotNull(deserialized);
            var facets = deserialized.Facets;
            var bucket = Assert.IsAssignableFrom<IProductSearchFacetResultBucket>(facets[0]);
            Assert.Equal("supplierName", bucket.Name);
            Assert.Equal("Example Inc.", bucket.Buckets[0].Key);
            Assert.Equal(77, bucket.Buckets[0].Count);

            var bucketByName = Assert.IsAssignableFrom<IProductSearchFacetResultBucket>(facets.Get("supplierName"));
            Assert.Equal("supplierName", bucketByName.Name);
            Assert.Equal("Example Inc.", bucketByName.Buckets[0].Key);
            Assert.Equal(77, bucketByName.Buckets[0].Count);

            var count = Assert.IsAssignableFrom<IProductSearchFacetResultCount>(facets[1]);
            Assert.Equal("supplierCounts", count.Name);
            Assert.Equal(10, count.Value);

            var countByName = Assert.IsAssignableFrom<IProductSearchFacetResultCount>(facets.Get("supplierCounts"));
            Assert.Equal("supplierCounts", countByName.Name);
            Assert.Equal(10, countByName.Value);

            var stats = Assert.IsAssignableFrom<IProductSearchFacetResultStats>(facets[2]);
            Assert.Equal("supplierCounts", count.Name);
            Assert.Equal(100, (long)stats.Min);
            Assert.Equal(300, (long)stats.Max);
            Assert.Equal(200, (long)stats.Mean);
            Assert.Equal(600, (long)stats.Sum);
            Assert.Equal(3, stats.Count);

            var statsByName = Assert.IsAssignableFrom<IProductSearchFacetResultStats>(facets.Get("pricesStatsVariants"));
            var longStats = statsByName.Get<long>();
            Assert.Equal(100, longStats.Min);
            Assert.Equal(300, longStats.Max);
            Assert.Equal(200, longStats.Mean);
            Assert.Equal(600, longStats.Sum);
            Assert.Equal(3, longStats.Count);

            var doubleStatsByName = Assert.IsAssignableFrom<IProductSearchFacetResultStats>(facets.Get("doubleStatsVariants"));
            var decimalStats = doubleStatsByName.Get<decimal>();
            Assert.Equal(100.3m, decimalStats.Min);
            Assert.Equal(300.6m, decimalStats.Max);
            Assert.Equal(200.4m, decimalStats.Mean);
            Assert.Equal(600.6m, decimalStats.Sum);
            Assert.Equal(3, decimalStats.Count);
            var serialize = serializerService.Serialize(deserialized);

            var dateStatsByName = Assert.IsAssignableFrom<IProductSearchFacetResultStats>(facets.Get("dateStatsVariants"));
            var dateStats = dateStatsByName.Get<string>();
            Assert.Equal(DateTime.Parse("2026-01-01"), dateStats.Min.AsDate());
            Assert.Equal(DateTime.Parse("2026-01-31"), dateStats.Max.AsDate());
            Assert.Equal(3, dateStats.Count);

            Assert.Equal("{\"total\":0,\"offset\":0,\"limit\":0,\"facets\":[{\"name\":\"supplierName\",\"buckets\":[{\"key\":\"Example Inc.\",\"count\":77}]},{\"name\":\"supplierCounts\",\"value\":10},{\"name\":\"pricesStatsVariants\",\"min\":100,\"max\":300,\"mean\":200,\"sum\":600,\"count\":3},{\"name\":\"dateStatsVariants\",\"min\":\"2026-01-01\",\"max\":\"2026-01-31\",\"count\":3},{\"name\":\"doubleStatsVariants\",\"min\":100.3,\"max\":300.6,\"mean\":200.4,\"sum\":600.6,\"count\":3}]}", serialize);
        }
    }
}
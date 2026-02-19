using System.IO;
using commercetools.Sdk.Api.Extensions;
using commercetools.Sdk.Api.Models.ProductSearches;
using Xunit;

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

            var statsByName = Assert.IsAssignableFrom<IProductSearchFacetResultStats>(facets.Get("supplierCounts"));
            var longStats = statsByName.Get<long>();
            Assert.Equal(100, longStats.Min);
            Assert.Equal(300, longStats.Max);
            Assert.Equal(200, longStats.Mean);
            Assert.Equal(600, longStats.Sum);
            Assert.Equal(3, longStats.Count);
            var serialize = serializerService.Serialize(deserialized);

            Assert.Equal("{\"total\":0,\"offset\":0,\"limit\":0,\"facets\":[{\"name\":\"supplierName\",\"buckets\":[{\"key\":\"Example Inc.\",\"count\":77}]},{\"name\":\"supplierCounts\",\"value\":10}]}", serialize);
        }
    }
}
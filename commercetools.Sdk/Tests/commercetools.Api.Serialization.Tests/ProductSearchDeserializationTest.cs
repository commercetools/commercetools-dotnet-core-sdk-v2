using System.IO;
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
            var count = Assert.IsAssignableFrom<IProductSearchFacetResultCount>(facets[1]);
            Assert.Equal("supplierCounts", count.Name);
            Assert.Equal(10, count.Value);

            var serialize = serializerService.Serialize(deserialized);

            Assert.Equal("{\"total\":0,\"offset\":0,\"limit\":0,\"facets\":[{\"name\":\"supplierName\",\"buckets\":[{\"key\":\"Example Inc.\",\"count\":77}]},{\"name\":\"supplierCounts\",\"value\":10}]}", serialize);
        }
    }
}
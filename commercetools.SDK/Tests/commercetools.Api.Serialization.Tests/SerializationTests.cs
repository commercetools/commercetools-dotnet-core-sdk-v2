using System;
using System.Globalization;
using System.IO;
using commercetools.Api.Models.ProductTypes;
using FluentAssertions;
using Newtonsoft.Json.Linq;
using Xunit;

namespace commercetools.Api.Serialization.Tests
{
    public class SerializationTests : IClassFixture<SerializationFixture>
    {
        private readonly SerializationFixture serializationFixture;

        public SerializationTests(SerializationFixture serializationFixture)
        {
            this.serializationFixture = serializationFixture;
        }

        [Fact]
        public void SerializeDateTime()
        {
            ISerializerService serializerService = this.serializationFixture.SerializerService;
            var dateTime = DateTime.Parse("2020-06-04T12:27:55.344Z", CultureInfo.GetCultureInfo("de-DE"));
            var dateTimeSerialized = serializerService.Serialize(dateTime);
            Assert.Equal("\"2020-06-04T12:27:55.344Z\"", dateTimeSerialized);
        }
        
        [Fact]
        public void ResourceIdentifierSerialization()
        {
            ISerializerService serializerService = this.serializationFixture.SerializerService;
            var productType = new ProductTypeResourceIdentifier
            {
                Key = "Key12",
                Id = "f40fcd15-b1c2-4279-9cfa-f6083e6a2988"
            };
            string result = serializerService.Serialize(productType);
            JToken resultFormatted = JValue.Parse(result);
            string serialized = File.ReadAllText("Resources/Types/ResourceIdentifier.json");
            JToken serializedFormatted = JValue.Parse(serialized);
            serializedFormatted.Should().BeEquivalentTo(resultFormatted);
        }
    }
}
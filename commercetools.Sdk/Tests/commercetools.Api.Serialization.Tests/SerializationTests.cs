using System;
using System.Globalization;
using System.IO;
using commercetools.Base.Models;
using commercetools.Sdk.Api.Models.ProductTypes;
using commercetools.Base.Serialization;
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
        public void SerializeDate()
        {
            ISerializerService serializerService = this.serializationFixture.SerializerService;

            var date = Date.Parse("2020-06-04T12:27:55.344Z", CultureInfo.GetCultureInfo("de-DE"));
            var dateSerialized = serializerService.Serialize(date);
            Assert.Equal("\"2020-06-04\"", dateSerialized);

            var dateTime = DateTime.Parse("2020-06-04T00:00:00.000Z", CultureInfo.GetCultureInfo("de-DE"), DateTimeStyles.AdjustToUniversal);
            var dateTimeSerialized = serializerService.Serialize(dateTime);
            Assert.Equal("\"2020-06-04T00:00:00Z\"", dateTimeSerialized);

            var d = DateTime.Parse("2020-06-04T00:00:00.000+02:00", CultureInfo.GetCultureInfo("de-DE"));
            var dSerialized = serializerService.Serialize(d);
            Assert.Equal("\"2020-06-03T22:00:00Z\"", dSerialized);
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
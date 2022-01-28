using commercetools.Api.Models.Common;
using Xunit;

namespace commercetools.Api.Serialization.Tests
{
    public class AddressTests : IClassFixture<SerializationFixture>
    {
        private readonly SerializationFixture _serializationFixture;

        public AddressTests(SerializationFixture serializationFixture)
        {
            this._serializationFixture = serializationFixture;
        }

        [Fact]
        public void poBoxAddress()
        {
            var serializerService = this._serializationFixture.SerializerService;
            var serialized = "{\"pOBox\": \"12345\"}";
            var deserialized = serializerService.Deserialize<Address>(serialized);
            Assert.NotNull(deserialized);
            Assert.Equal("12345", deserialized.POBox);

            Assert.Equal("{\"pOBox\":\"12345\"}", serializerService.Serialize(deserialized));
        }
        [Fact]
        public void poBoxAddressDraft()
        {
            var serializerService = this._serializationFixture.SerializerService;
            var serialized = "{\"pOBox\": \"12345\"}";
            var deserialized = serializerService.Deserialize<AddressDraft>(serialized);
            Assert.NotNull(deserialized);
            Assert.Equal("12345", deserialized.POBox);

            Assert.Equal("{\"pOBox\":\"12345\"}", serializerService.Serialize(deserialized));
        }

    }
}
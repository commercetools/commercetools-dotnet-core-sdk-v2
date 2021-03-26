using System.Collections.Generic;
using System.IO;
using System.Linq;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.Products;
using commercetools.Api.Models.ProductTypes;
using Xunit;

namespace commercetools.Api.Serialization.Tests
{
    public class AttributesTests : IClassFixture<SerializationFixture>
    {
        private readonly SerializationFixture _serializationFixture;

        public AttributesTests(SerializationFixture serializationFixture)
        {
            this._serializationFixture = serializationFixture;
        }

        [Fact]
        public void AttributesDeserialization()
        {
            var serializerService = this._serializationFixture.SerializerService;
            var serialized = File.ReadAllText("Resources/Attributes/List.json");
            var deserialized = serializerService.Deserialize<ProductVariant>(serialized);
            Assert.NotNull(deserialized);
            var attributes = deserialized.Attributes;
            Assert.IsType<string>(attributes.Get("text"));
            Assert.IsType<LocalizedString>(attributes.Get("ltext"));
            Assert.IsAssignableFrom<IAttributePlainEnumValue>(attributes.Get("enum"));
            Assert.IsAssignableFrom<IAttributeLocalizedEnumValue>(attributes.Get("lenum"));
            Assert.IsType<string>(attributes.Get("date"));
            Assert.IsType<string>(attributes.Get("time"));
            Assert.IsType<string>(attributes.Get("datetime"));
            Assert.IsType<bool>(attributes.Get("boolean"));
            Assert.IsType<long>(attributes.Get("integer"));
            Assert.IsType<decimal>(attributes.Get("double"));
            Assert.IsType<ProductReference>(attributes.Get("reference"));
            Assert.IsAssignableFrom<ITypedMoney>(attributes.Get("money"));
            Assert.IsType<List<IAttribute>>(attributes.Get("nested"));
            
            Assert.IsType<List<object>>(attributes.Get("set-empty"));
            Assert.IsType<List<string>>(attributes.Get("set-text"));
            Assert.IsType<List<LocalizedString>>(attributes.Get("set-ltext"));
            Assert.IsType<List<long>>(attributes.Get("set-integer"));
            Assert.IsType<List<decimal>>(attributes.Get("set-double"));
            Assert.IsType<List<IAttributePlainEnumValue>>(attributes.Get("set-enum"));
            Assert.IsType<List<IAttributeLocalizedEnumValue>>(attributes.Get("set-lenum"));
            Assert.IsType<List<ITypedMoney>>(attributes.Get("set-money"));
            Assert.IsType<List<IReference>>(attributes.Get("set-reference"));
            Assert.IsType<List<string>>(attributes.Get("set-date"));
            Assert.IsType<List<string>>(attributes.Get("set-datetime"));
            Assert.IsType<List<string>>(attributes.Get("set-time"));
            Assert.IsType<List<bool>>(attributes.Get("set-boolean"));
            Assert.IsType<List<List<IAttribute>>>(attributes.Get("set-nested"));
        }
        
        [Fact]
        public void DecimalDeserialization()
        {
            var serializerService = this._serializationFixture.SerializerService;
            var serialized = "{\"attributes\": [{\"name\": \"t\", \"value\": 13.0}]}";
            var deserialized = serializerService.Deserialize<ProductVariant>(serialized);
            Assert.NotNull(deserialized);
            var attributes = deserialized.Attributes;
            Assert.IsType<decimal>(attributes.Get("t"));

            Assert.Equal("{\"id\":0,\"attributes\":[{\"name\":\"t\",\"value\":13.0}]}", serializerService.Serialize(deserialized));
        }
        
        [Fact]
        public void IntDeserialization()
        {
            var serializerService = this._serializationFixture.SerializerService;
            var serialized = "{\"attributes\": [{\"name\": \"t\", \"value\": 13}]}";
            var deserialized = serializerService.Deserialize<ProductVariant>(serialized);
            Assert.NotNull(deserialized);
            var attributes = deserialized.Attributes;
            Assert.IsType<long>(attributes.Get("t"));
            Assert.Equal("{\"id\":0,\"attributes\":[{\"name\":\"t\",\"value\":13}]}", serializerService.Serialize(deserialized));
        }
    }
}
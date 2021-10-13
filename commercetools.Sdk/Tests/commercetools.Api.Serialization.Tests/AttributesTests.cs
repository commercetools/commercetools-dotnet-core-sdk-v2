using System.Collections.Generic;
using System.IO;
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
        public void AttributesTypesDeserialization()
        {
            var serializerService = this._serializationFixture.SerializerService;
            var serialized = File.ReadAllText("Resources/Attributes/List.json");
            var deserialized = serializerService.Deserialize<ProductVariant>(serialized);
            Assert.NotNull(deserialized);
            var attributes = deserialized.Attributes;
            Assert.IsType<StringAttribute>(attributes.GetAttribute<StringAttribute>("text"));
            Assert.IsType<LocalizedStringAttribute>(attributes.GetAttribute<LocalizedStringAttribute>("ltext"));
            Assert.IsType<PlainEnumAttribute>(attributes.GetAttribute<PlainEnumAttribute>("enum"));
            Assert.IsType<LocalizedEnumAttribute>(attributes.GetAttribute<LocalizedEnumAttribute>("lenum"));
            Assert.IsType<StringAttribute>(attributes.GetAttribute<StringAttribute>("date"));
            Assert.IsType<StringAttribute>(attributes.GetAttribute<StringAttribute>("time"));
            Assert.IsType<StringAttribute>(attributes.GetAttribute<StringAttribute>("datetime"));
            Assert.IsType<BooleanAttribute>(attributes.GetAttribute<BooleanAttribute>("boolean"));
            Assert.IsType<LongAttribute>(attributes.GetAttribute<LongAttribute>("integer"));
            Assert.IsType<DecimalAttribute>(attributes.GetAttribute<DecimalAttribute>("double"));
            Assert.IsType<ReferenceAttribute>(attributes.GetAttribute<ReferenceAttribute>("reference"));
            Assert.IsType<MoneyAttribute>(attributes.GetAttribute<MoneyAttribute>("money"));
            Assert.IsType<NestedAttribute>(attributes.GetAttribute<NestedAttribute>("nested"));
            
            Assert.IsType<SetAttribute<object>>(attributes.GetAttribute<SetAttribute<object>>("set-empty"));
            Assert.IsType<SetAttribute<string>>(attributes.GetAttribute<SetAttribute<string>>("set-text"));
            Assert.IsType<SetAttribute<LocalizedString>>(attributes.GetAttribute<SetAttribute<LocalizedString>>("set-ltext"));
            Assert.IsType<SetAttribute<long>>(attributes.GetAttribute<SetAttribute<long>>("set-integer"));
            Assert.IsType<SetAttribute<decimal>>(attributes.GetAttribute<SetAttribute<decimal>>("set-double"));
            Assert.IsType<SetAttribute<IAttributePlainEnumValue>>(attributes.GetAttribute<SetAttribute<IAttributePlainEnumValue>>("set-enum"));
            Assert.IsType<SetAttribute<IAttributeLocalizedEnumValue>>(attributes.GetAttribute<SetAttribute<IAttributeLocalizedEnumValue>>("set-lenum"));
            Assert.IsType<SetAttribute<ITypedMoney>>(attributes.GetAttribute<SetAttribute<ITypedMoney>>("set-money"));
            Assert.IsType<SetAttribute<IReference>>(attributes.GetAttribute<SetAttribute<IReference>>("set-reference"));
            Assert.IsType<SetAttribute<string>>(attributes.GetAttribute<SetAttribute<string>>("set-date"));
            Assert.IsType<SetAttribute<string>>(attributes.GetAttribute<SetAttribute<string>>("set-datetime"));
            Assert.IsType<SetAttribute<string>>(attributes.GetAttribute<SetAttribute<string>>("set-time"));
            Assert.IsType<SetAttribute<bool>>(attributes.GetAttribute<SetAttribute<bool>>("set-boolean"));
            Assert.IsType<SetAttribute<List<IAttribute>>>(attributes.GetAttribute<SetAttribute<List<IAttribute>>>("set-nested"));
            
            Assert.IsType<string>(attributes.GetAttribute<StringAttribute>("text").GetValue());
            Assert.IsType<LocalizedString>(attributes.GetAttribute<LocalizedStringAttribute>("ltext").GetValue());
            Assert.IsAssignableFrom<IAttributePlainEnumValue>(attributes.GetAttribute<PlainEnumAttribute>("enum").GetValue());
            Assert.IsAssignableFrom<IAttributeLocalizedEnumValue>(attributes.GetAttribute<LocalizedEnumAttribute>("lenum").GetValue());
            Assert.IsType<string>(attributes.GetAttribute<StringAttribute>("date").GetValue());
            Assert.IsType<string>(attributes.GetAttribute<StringAttribute>("time").GetValue());
            Assert.IsType<string>(attributes.GetAttribute<StringAttribute>("datetime").GetValue());
            Assert.IsType<bool>(attributes.GetAttribute<BooleanAttribute>("boolean").GetValue());
            Assert.IsType<long>(attributes.GetAttribute<LongAttribute>("integer").GetValue());
            Assert.IsType<decimal>(attributes.GetAttribute<DecimalAttribute>("double").GetValue());
            Assert.IsType<ProductReference>(attributes.GetAttribute<ReferenceAttribute>("reference").GetValue());
            Assert.IsAssignableFrom<ITypedMoney>(attributes.GetAttribute<MoneyAttribute>("money").GetValue());
            Assert.IsType<List<IAttribute>>(attributes.GetAttribute<NestedAttribute>("nested").GetValue());

            Assert.IsType<List<object>>(attributes.GetAttribute<SetAttribute<object>>("set-empty").GetValue());
            Assert.IsType<List<string>>(attributes.GetAttribute<SetAttribute<string>>("set-text").GetValue());
            Assert.IsType<List<LocalizedString>>(attributes.GetAttribute<SetAttribute<LocalizedString>>("set-ltext").GetValue());
            Assert.IsType<List<long>>(attributes.GetAttribute<SetAttribute<long>>("set-integer").GetValue());
            Assert.IsType<List<decimal>>(attributes.GetAttribute<SetAttribute<decimal>>("set-double").GetValue());
            Assert.IsType<List<IAttributePlainEnumValue>>(attributes.GetAttribute<SetAttribute<IAttributePlainEnumValue>>("set-enum").GetValue());
            Assert.IsType<List<IAttributeLocalizedEnumValue>>(attributes.GetAttribute<SetAttribute<IAttributeLocalizedEnumValue>>("set-lenum").GetValue());
            Assert.IsType<List<ITypedMoney>>(attributes.GetAttribute<SetAttribute<ITypedMoney>>("set-money").GetValue());
            Assert.IsType<List<IReference>>(attributes.GetAttribute<SetAttribute<IReference>>("set-reference").GetValue());
            Assert.IsType<List<string>>(attributes.GetAttribute<SetAttribute<string>>("set-date").GetValue());
            Assert.IsType<List<string>>(attributes.GetAttribute<SetAttribute<string>>("set-datetime").GetValue());
            Assert.IsType<List<string>>(attributes.GetAttribute<SetAttribute<string>>("set-time").GetValue());
            Assert.IsType<List<bool>>(attributes.GetAttribute<SetAttribute<bool>>("set-boolean").GetValue());
            Assert.IsType<List<List<IAttribute>>>(attributes.GetAttribute<SetAttribute<List<IAttribute>>>("set-nested").GetValue());
            
            Assert.Equal("set-nested-enum", attributes.GetAttribute<SetAttribute<List<IAttribute>>>("set-nested").GetValue()[0][0].Name);
            Assert.IsType<PlainEnumAttribute>(attributes.GetAttribute<SetAttribute<List<IAttribute>>>("set-nested").GetValue()[0][0]);
            Assert.Equal("set-nested-reference", attributes.GetAttribute<SetAttribute<List<IAttribute>>>("set-nested").GetValue()[1][0].Name);
            Assert.IsType<ReferenceAttribute>(attributes.GetAttribute<SetAttribute<List<IAttribute>>>("set-nested").GetValue()[1][0]);
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
using System;
using System.Collections.Generic;
using System.IO;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Products;
using commercetools.Sdk.Api.Models.ProductTypes;
using commercetools.Sdk.Api.Extensions;
using Xunit;
using Attribute = commercetools.Sdk.Api.Models.Products.Attribute;

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
            Assert.IsType<string>(attributes.Get("text").Value);
            Assert.IsType<LocalizedString>(attributes.Get("ltext").Value);
            Assert.IsAssignableFrom<IAttributePlainEnumValue>(attributes.Get("enum").Value);
            Assert.IsAssignableFrom<IAttributeLocalizedEnumValue>(attributes.Get("lenum").Value);
            Assert.IsType<string>(attributes.Get("date").Value);
            Assert.IsType<string>(attributes.Get("time").Value);
            Assert.IsType<string>(attributes.Get("datetime").Value);
            Assert.IsType<bool>(attributes.Get("boolean").Value);
            Assert.IsType<long>(attributes.Get("integer").Value);
            Assert.IsType<decimal>(attributes.Get("double").Value);
            Assert.IsType<decimal>(attributes.Get("double-zero").Value);
            Assert.IsType<ProductReference>(attributes.Get("reference").Value);
            Assert.IsAssignableFrom<ITypedMoney>(attributes.Get("money").Value);
            Assert.IsType<List<IAttribute>>(attributes.Get("nested").Value);

            Assert.IsType<List<object>>(attributes.Get("set-empty").Value);
            Assert.IsType<List<string>>(attributes.Get("set-text").Value);
            Assert.IsType<List<LocalizedString>>(attributes.Get("set-ltext").Value);
            Assert.IsType<List<long>>(attributes.Get("set-integer").Value);
            Assert.IsType<List<decimal>>(attributes.Get("set-double").Value);
            Assert.IsType<List<decimal>>(attributes.Get("set-double-zero").Value);
            Assert.IsType<List<IAttributePlainEnumValue>>(attributes.Get("set-enum").Value);
            Assert.IsType<List<IAttributeLocalizedEnumValue>>(attributes.Get("set-lenum").Value);
            Assert.IsType<List<ITypedMoney>>(attributes.Get("set-money").Value);
            Assert.IsType<List<IReference>>(attributes.Get("set-reference").Value);
            Assert.IsType<List<string>>(attributes.Get("set-date").Value);
            Assert.IsType<List<string>>(attributes.Get("set-datetime").Value);
            Assert.IsType<List<string>>(attributes.Get("set-time").Value);
            Assert.IsType<List<bool>>(attributes.Get("set-boolean").Value);
            Assert.IsType<List<List<IAttribute>>>(attributes.Get("set-nested").Value);
        }

        [Fact]
        public void AttributesTypesDeserialization()
        {
            var serializerService = this._serializationFixture.SerializerService;
            var serialized = File.ReadAllText("Resources/Attributes/List.json");
            var deserialized = serializerService.Deserialize<ProductVariant>(serialized);
            Assert.NotNull(deserialized);
            var attributes = deserialized.Attributes;
            Assert.IsType<StringAttribute>(attributes.Get<StringAttribute>("text"));
            Assert.IsType<LocalizedStringAttribute>(attributes.Get<LocalizedStringAttribute>("ltext"));
            Assert.IsType<PlainEnumAttribute>(attributes.Get<PlainEnumAttribute>("enum"));
            Assert.IsType<LocalizedEnumAttribute>(attributes.Get<LocalizedEnumAttribute>("lenum"));
            Assert.IsType<StringAttribute>(attributes.Get<StringAttribute>("date"));
            Assert.IsType<StringAttribute>(attributes.Get<StringAttribute>("time"));
            Assert.IsType<StringAttribute>(attributes.Get<StringAttribute>("datetime"));
            Assert.IsType<BooleanAttribute>(attributes.Get<BooleanAttribute>("boolean"));
            Assert.IsType<LongAttribute>(attributes.Get<LongAttribute>("integer"));
            Assert.IsType<DecimalAttribute>(attributes.Get<DecimalAttribute>("integer"));
            Assert.IsType<DecimalAttribute>(attributes.Get<DecimalAttribute>("double"));
            Assert.IsType<DecimalAttribute>(attributes.Get<DecimalAttribute>("double-zero"));
            Assert.IsType<ReferenceAttribute>(attributes.Get<ReferenceAttribute>("reference"));
            Assert.IsType<MoneyAttribute>(attributes.Get<MoneyAttribute>("money"));
            Assert.IsType<NestedAttribute>(attributes.Get<NestedAttribute>("nested"));
            
            Assert.IsType<SetAttribute<object>>(attributes.Get<SetAttribute<object>>("set-empty"));
            Assert.IsType<SetAttribute<string>>(attributes.Get<SetAttribute<string>>("set-text"));
            Assert.IsType<SetAttribute<LocalizedString>>(attributes.Get<SetAttribute<LocalizedString>>("set-ltext"));
            Assert.IsType<SetAttribute<long>>(attributes.Get<SetAttribute<long>>("set-integer"));
            Assert.IsType<SetAttribute<decimal>>(attributes.Get<SetAttribute<decimal>>("set-double"));
            Assert.IsType<SetAttribute<decimal>>(attributes.Get<SetAttribute<decimal>>("set-double-zero"));
            Assert.IsType<SetAttribute<IAttributePlainEnumValue>>(attributes.Get<SetAttribute<IAttributePlainEnumValue>>("set-enum"));
            Assert.IsType<SetAttribute<IAttributeLocalizedEnumValue>>(attributes.Get<SetAttribute<IAttributeLocalizedEnumValue>>("set-lenum"));
            Assert.IsType<SetAttribute<ITypedMoney>>(attributes.Get<SetAttribute<ITypedMoney>>("set-money"));
            Assert.IsType<SetAttribute<IReference>>(attributes.Get<SetAttribute<IReference>>("set-reference"));
            Assert.IsType<SetAttribute<string>>(attributes.Get<SetAttribute<string>>("set-date"));
            Assert.IsType<SetAttribute<string>>(attributes.Get<SetAttribute<string>>("set-datetime"));
            Assert.IsType<SetAttribute<string>>(attributes.Get<SetAttribute<string>>("set-time"));
            Assert.IsType<SetAttribute<bool>>(attributes.Get<SetAttribute<bool>>("set-boolean"));
            Assert.IsType<SetAttribute<List<IAttribute>>>(attributes.Get<SetAttribute<List<IAttribute>>>("set-nested"));
            
            Assert.IsType<string>(attributes.Get<StringAttribute>("text").GetValue());
            Assert.IsType<LocalizedString>(attributes.Get<LocalizedStringAttribute>("ltext").GetValue());
            Assert.IsAssignableFrom<IAttributePlainEnumValue>(attributes.Get<PlainEnumAttribute>("enum").GetValue());
            Assert.IsAssignableFrom<IAttributeLocalizedEnumValue>(attributes.Get<LocalizedEnumAttribute>("lenum").GetValue());
            Assert.IsType<string>(attributes.Get<StringAttribute>("date").GetValue());
            Assert.IsType<string>(attributes.Get<StringAttribute>("time").GetValue());
            Assert.IsType<string>(attributes.Get<StringAttribute>("datetime").GetValue());
            Assert.IsType<bool>(attributes.Get<BooleanAttribute>("boolean").GetValue());
            Assert.IsType<long>(attributes.Get<LongAttribute>("integer").GetValue());
            Assert.IsType<decimal>(attributes.Get<DecimalAttribute>("integer").GetValue());
            Assert.IsType<decimal>(attributes.Get<DecimalAttribute>("double").GetValue());
            Assert.IsType<ProductReference>(attributes.Get<ReferenceAttribute>("reference").GetValue());
            Assert.IsAssignableFrom<ITypedMoney>(attributes.Get<MoneyAttribute>("money").GetValue());
            Assert.IsType<List<IAttribute>>(attributes.Get<NestedAttribute>("nested").GetValue());
            
            Assert.IsType<List<object>>(attributes.Get<SetAttribute<object>>("set-empty").GetValue());
            Assert.IsType<List<string>>(attributes.Get<SetAttribute<string>>("set-text").GetValue());
            Assert.IsType<List<LocalizedString>>(attributes.Get<SetAttribute<LocalizedString>>("set-ltext").GetValue());
            Assert.IsType<List<long>>(attributes.Get<SetAttribute<long>>("set-integer").GetValue());
            Assert.IsType<List<decimal>>(attributes.Get<SetAttribute<decimal>>("set-double").GetValue());
            Assert.IsType<List<IAttributePlainEnumValue>>(attributes.Get<SetAttribute<IAttributePlainEnumValue>>("set-enum").GetValue());
            Assert.IsType<List<IAttributeLocalizedEnumValue>>(attributes.Get<SetAttribute<IAttributeLocalizedEnumValue>>("set-lenum").GetValue());
            Assert.IsType<List<ITypedMoney>>(attributes.Get<SetAttribute<ITypedMoney>>("set-money").GetValue());
            Assert.IsType<List<IReference>>(attributes.Get<SetAttribute<IReference>>("set-reference").GetValue());
            Assert.IsType<List<string>>(attributes.Get<SetAttribute<string>>("set-date").GetValue());
            Assert.IsType<List<string>>(attributes.Get<SetAttribute<string>>("set-datetime").GetValue());
            Assert.IsType<List<string>>(attributes.Get<SetAttribute<string>>("set-time").GetValue());
            Assert.IsType<List<bool>>(attributes.Get<SetAttribute<bool>>("set-boolean").GetValue());
            Assert.IsType<List<List<IAttribute>>>(attributes.Get<SetAttribute<List<IAttribute>>>("set-nested").GetValue());
            
            Assert.Equal("set-nested-enum", attributes.Get<SetAttribute<List<IAttribute>>>("set-nested").GetValue()[0][0].Name);
            Assert.IsType<PlainEnumAttribute>(attributes.Get<SetAttribute<List<IAttribute>>>("set-nested").GetValue()[0][0]);
            Assert.Equal("set-nested-reference", attributes.Get<SetAttribute<List<IAttribute>>>("set-nested").GetValue()[1][0].Name);
            Assert.IsType<ReferenceAttribute>(attributes.Get<SetAttribute<List<IAttribute>>>("set-nested").GetValue()[1][0]);
        }

        [Fact]
        public void AttributesAsTypesDeserialization()
        {
            var serializerService = this._serializationFixture.SerializerService;
            var serialized = File.ReadAllText("Resources/Attributes/List.json");
            var deserialized = serializerService.Deserialize<ProductVariant>(serialized);
            Assert.NotNull(deserialized);
            var attributes = deserialized.Attributes;
            Assert.IsType<StringAttribute>(attributes.Get("text").ToStringAttribute());
            Assert.IsType<LocalizedStringAttribute>(attributes.Get("ltext").ToLocalizedStringAttribute());
            Assert.IsType<PlainEnumAttribute>(attributes.Get("enum").ToPlainEnumAttribute());
            Assert.IsType<LocalizedEnumAttribute>(attributes.Get("lenum").ToLocalizedEnumAttribute());
            Assert.IsType<StringAttribute>(attributes.Get("date").ToStringAttribute());
            Assert.IsType<StringAttribute>(attributes.Get("time").ToStringAttribute());
            Assert.IsType<StringAttribute>(attributes.Get("datetime").ToStringAttribute());
            Assert.IsType<BooleanAttribute>(attributes.Get("boolean").ToBooleanAttribute());
            Assert.IsType<LongAttribute>(attributes.Get("integer").ToLongAttribute());
            Assert.IsType<DecimalAttribute>(attributes.Get("integer").ToDecimalAttribute());
            Assert.IsType<DecimalAttribute>(attributes.Get("double").ToDecimalAttribute());
            Assert.IsType<DecimalAttribute>(attributes.Get("double-zero").ToDecimalAttribute());
            Assert.IsType<ReferenceAttribute>(attributes.Get("reference").ToReferenceAttribute());
            Assert.IsType<MoneyAttribute>(attributes.Get("money").ToMoneyAttribute());
            Assert.IsType<NestedAttribute>(attributes.Get("nested").ToNestedAttribute());

            Assert.Null(attributes.Get("set-empty").ToSetStringAttribute());
            Assert.IsType<SetAttribute<string>>(attributes.Get("set-text").ToSetStringAttribute());
            Assert.IsType<SetAttribute<LocalizedString>>(attributes.Get("set-ltext").ToSetLocalizedStringAttribute());
            Assert.IsType<SetAttribute<long>>(attributes.Get("set-integer").ToSetLongAttribute());
            Assert.IsType<SetAttribute<decimal>>(attributes.Get("set-double").ToSetDecimalAttribute());
            Assert.IsType<SetAttribute<decimal>>(attributes.Get("set-double-zero").ToSetDecimalAttribute());
            Assert.IsType<SetAttribute<IAttributePlainEnumValue>>(attributes.Get("set-enum").ToSetPlainEnumAttribute());
            Assert.IsType<SetAttribute<IAttributeLocalizedEnumValue>>(attributes.Get("set-lenum").ToSetLocalizedEnumAttribute());
            Assert.IsType<SetAttribute<ITypedMoney>>(attributes.Get("set-money").ToSetMoneyAttribute());
            Assert.IsType<SetAttribute<IReference>>(attributes.Get("set-reference").ToSetReferenceAttribute());
            Assert.IsType<SetAttribute<string>>(attributes.Get("set-date").ToSetStringAttribute());
            Assert.IsType<SetAttribute<string>>(attributes.Get("set-datetime").ToSetStringAttribute());
            Assert.IsType<SetAttribute<string>>(attributes.Get("set-time").ToSetStringAttribute());
            Assert.IsType<SetAttribute<bool>>(attributes.Get("set-boolean").ToSetBooleanAttribute());
            Assert.IsType<SetAttribute<List<IAttribute>>>(attributes.Get("set-nested").ToSetOfNestedAttribute());

            Assert.IsType<string>(attributes.Get("text").ToStringAttribute()?.GetValue());
            Assert.IsType<LocalizedString>(attributes.Get("ltext").ToLocalizedStringAttribute()?.GetValue());
            Assert.IsAssignableFrom<IAttributePlainEnumValue>(attributes.Get("enum").ToPlainEnumAttribute()?.GetValue());
            Assert.IsAssignableFrom<IAttributeLocalizedEnumValue>(attributes.Get("lenum").ToLocalizedEnumAttribute()?.GetValue());
            Assert.IsType<string>(attributes.Get("date").ToStringAttribute()?.GetValue());
            Assert.IsType<string>(attributes.Get("time").ToStringAttribute()?.GetValue());
            Assert.IsType<string>(attributes.Get("datetime").ToStringAttribute()?.GetValue());
            Assert.IsType<bool>(attributes.Get("boolean").ToBooleanAttribute()?.GetValue());
            Assert.IsType<long>(attributes.Get("integer").ToLongAttribute()?.GetValue());
            Assert.IsType<decimal>(attributes.Get("integer").ToDecimalAttribute()?.GetValue());
            Assert.IsType<decimal>(attributes.Get("double").ToDecimalAttribute()?.GetValue());
            Assert.IsType<ProductReference>(attributes.Get("reference").ToReferenceAttribute()?.GetValue());
            Assert.IsAssignableFrom<ITypedMoney>(attributes.Get("money").ToMoneyAttribute()?.GetValue());
            Assert.IsType<List<IAttribute>>(attributes.Get("nested").ToNestedAttribute()?.GetValue());

            Assert.Null(attributes.Get("set-empty").ToSetStringAttribute()?.GetValue());
            Assert.IsType<List<string>>(attributes.Get("set-text").ToSetStringAttribute()?.GetValue());
            Assert.IsType<List<LocalizedString>>(attributes.Get("set-ltext").ToSetLocalizedStringAttribute()?.GetValue());
            Assert.IsType<List<long>>(attributes.Get("set-integer").ToSetLongAttribute()?.GetValue());
            Assert.IsType<List<decimal>>(attributes.Get("set-double").ToSetDecimalAttribute()?.GetValue());
            Assert.IsType<List<IAttributePlainEnumValue>>(attributes.Get("set-enum").ToSetPlainEnumAttribute()?.GetValue());
            Assert.IsType<List<IAttributeLocalizedEnumValue>>(attributes.Get("set-lenum").ToSetLocalizedEnumAttribute()?.GetValue());
            Assert.IsType<List<ITypedMoney>>(attributes.Get("set-money").ToSetMoneyAttribute()?.GetValue());
            Assert.IsType<List<IReference>>(attributes.Get("set-reference").ToSetReferenceAttribute()?.GetValue());
            Assert.IsType<List<string>>(attributes.Get("set-date").ToSetStringAttribute()?.GetValue());
            Assert.IsType<List<string>>(attributes.Get("set-datetime").ToSetStringAttribute()?.GetValue());
            Assert.IsType<List<string>>(attributes.Get("set-time").ToSetStringAttribute()?.GetValue());
            Assert.IsType<List<bool>>(attributes.Get("set-boolean").ToSetBooleanAttribute()?.GetValue());
            Assert.IsType<List<List<IAttribute>>>(attributes.Get("set-nested").ToSetOfNestedAttribute()?.GetValue());

            Assert.Equal("set-nested-enum", attributes.Get("set-nested").ToSetOfNestedAttribute()?.GetValue()[0][0].Name);
            Assert.IsType<PlainEnumAttribute>(attributes.Get("set-nested").ToSetOfNestedAttribute()?.GetValue()[0][0]);
            Assert.Equal("set-nested-reference", attributes.Get("set-nested").ToSetOfNestedAttribute()?.GetValue()[1][0].Name);
            Assert.IsType<ReferenceAttribute>(attributes.Get("set-nested").ToSetOfNestedAttribute()?.GetValue()[1][0]);
        }

        [Fact]
        public void DecimalDeserialization()
        {
            var serializerService = this._serializationFixture.SerializerService;
            var serialized = "{\"attributes\": [{\"name\": \"t\", \"value\": 13.0}]}";
            var deserialized = serializerService.Deserialize<ProductVariant>(serialized);
            Assert.NotNull(deserialized);
            var attributes = deserialized.Attributes;
            Assert.IsType<decimal>(attributes.Get("t").Value);

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
            Assert.IsType<long>(attributes.Get("t").Value);
            Assert.Equal("{\"id\":0,\"attributes\":[{\"name\":\"t\",\"value\":13}]}", serializerService.Serialize(deserialized));
        }

        [Fact]
        public void DecimalSerialization()
        {
            var serializerService = this._serializationFixture.SerializerService;
            var attributes = new List<Attribute>
                {
                    new DecimalAttribute() { Name = "decimal", Value = 13m },
                    new DecimalAttribute() { Name = "decimal-zero", Value = 13.0m },
                    new DecimalAttribute() { Name = "double", Value = 13d },
                    new DecimalAttribute() { Name = "double-zero", Value = 13.0d },
                    new LongAttribute() { Name = "long", Value = 13 }
                };
            Assert.Equal("[{\"name\":\"decimal\",\"value\":13},{\"name\":\"decimal-zero\",\"value\":13.0},{\"name\":\"double\",\"value\":13},{\"name\":\"double-zero\",\"value\":13},{\"name\":\"long\",\"value\":13}]", serializerService.Serialize(attributes));
            
        }
    }
}
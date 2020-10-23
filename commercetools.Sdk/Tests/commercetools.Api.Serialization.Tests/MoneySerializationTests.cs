using System.Text.Json;
using commercetools.Api.Models.Common;
using commercetools.Base.Serialization;
using FluentAssertions;
using Newtonsoft.Json.Linq;
using Xunit;

namespace commercetools.Api.Serialization.Tests
{
    public class MoneySerializationTests : IClassFixture<SerializationFixture>
    {
        private readonly SerializationFixture serializationFixture;

        public MoneySerializationTests(SerializationFixture serializationFixture)
        {
            this.serializationFixture = serializationFixture;
        }

        [Fact]
        public void MoneyDeserialization()
        {
            ISerializerService serializerService = this.serializationFixture.SerializerService;
            string serialized = @"{
                ""currencyCode"": ""EUR"",
                ""centAmount"": 123456
            }";
            var deserialized = serializerService.Deserialize<ITypedMoney>(serialized);
            Assert.IsType<Money>(deserialized);
        }

        
        [Fact]
        public void MoneyWithTypeDeserialization()
        {
            ISerializerService serializerService = this.serializationFixture.SerializerService;
            string serialized = @"{
                ""type"": ""centPrecision"",
                ""currencyCode"": ""EUR"",
                ""centAmount"": 123456,
                ""fractionDigits"": 2
            }";
            var deserialized = serializerService.Deserialize<ITypedMoney>(serialized);
            Assert.IsType<CentPrecisionMoney>(deserialized);
            Assert.Equal("EUR", deserialized.CurrencyCode);
            Assert.Equal(MoneyType.CentPrecision, deserialized.TypeAsEnum);
            Assert.Equal(1234.56M, deserialized.AmountToDecimal());
            Assert.Equal(2, deserialized.FractionDigits);
        }

        [Fact]
        public void HighPrecisionMoneyDeserialization()
        {
            ISerializerService serializerService = this.serializationFixture.SerializerService;
            string serialized = @"{
                ""type"": ""highPrecision"",
                ""currencyCode"": ""EUR"",
                ""centAmount"": 123456,
                ""preciseAmount"": 12345678,
                ""fractionDigits"": 4
            }";
            var deserialized = serializerService.Deserialize<ITypedMoney>(serialized);
            var highPrecisionMoney = deserialized as HighPrecisionMoney;
            Assert.NotNull(highPrecisionMoney);
            Assert.Equal("EUR", highPrecisionMoney.CurrencyCode);
            Assert.Equal(MoneyType.HighPrecision, highPrecisionMoney.TypeAsEnum);
            Assert.Equal(123456, highPrecisionMoney.CentAmount);
            Assert.Equal(1234.5678M, highPrecisionMoney.AmountToDecimal());
            Assert.Equal(4, highPrecisionMoney.FractionDigits);
        }

        
        [Fact]
        public void HighPrecisionMoneySerialization()
        {
            ISerializerService serializerService = this.serializationFixture.SerializerService;
            var m = HighPrecisionMoney.FromDecimal("EUR", 1234.56789M, 4);

            var serialize = serializerService.Serialize(m);
            var resultFormatted = JValue.Parse(serialize);
            JToken serializedFormatted = JValue.Parse(@"{""type"":""highPrecision"",""preciseAmount"":12345679,""currencyCode"":""EUR"",""centAmount"":123457,""fractionDigits"":4}");
            serializedFormatted.Should().BeEquivalentTo(resultFormatted);
        }
        

        [Fact]
        public void CentPrecisionMoneySerialization()
        {
            ISerializerService serializerService = this.serializationFixture.SerializerService;
            var m = CentPrecisionMoney.FromDecimal("EUR", 1234.5678M);

            var serialize = serializerService.Serialize(m);
            JToken resultFormatted = JValue.Parse(serialize);
            JToken serializedFormatted = JValue.Parse(@"{""type"":""centPrecision"",""currencyCode"":""EUR"",""centAmount"":123457}");
            serializedFormatted.Should().BeEquivalentTo(resultFormatted);
        }

        [Fact]
        public void DeserializeInvalidMoney()
        {
            ISerializerService serializerService = this.serializationFixture.SerializerService;
            string serialized = @"{
                ""type"": ""unknown"",
                ""centAmount"": 123456
            }";

            Assert.Throws<JsonException>(() => serializerService.Deserialize<ITypedMoney>(serialized));
        }
    }
}
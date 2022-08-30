using commercetools.Sdk.Api.Models.Common;
using Xunit;

namespace commercetools.Sdk.Api.Tests
{
    public class MoneyTests
    {
        
        [Fact]
        public void TypedMoney_ZeroFractionCulture()
        {
            var typedMoney = new TypedMoney() { CentAmount = 1000, CurrencyCode = "ko-KR", FractionDigits = 0 };
            var centMoney = ITypedMoney.CentPrecision(precisionMoney =>
            {
                precisionMoney.CentAmount = 1000;
                precisionMoney.FractionDigits = 0;
                precisionMoney.CurrencyCode = "ko-KR";
            });
            var highMoney = ITypedMoney.HighPrecision(precisionMoney =>
            {
                precisionMoney.PreciseAmount = 1000;
                precisionMoney.FractionDigits = 0;
                precisionMoney.CurrencyCode = "ko-KR";
            });

            Assert.Equal(1000, typedMoney.AmountToDecimal());
            Assert.Equal(1000, centMoney.AmountToDecimal());
            Assert.Equal(1000, highMoney.AmountToDecimal());
        }

    }
}
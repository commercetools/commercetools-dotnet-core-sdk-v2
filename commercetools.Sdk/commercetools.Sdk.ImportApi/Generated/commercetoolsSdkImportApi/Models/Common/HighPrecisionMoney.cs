

namespace commercetools.Sdk.ImportApi.Models.Common
{

    public partial class HighPrecisionMoney : IHighPrecisionMoney
    {
        public IMoneyType Type { get; set; }

        public int? FractionDigits { get; set; }

        public long CentAmount { get; set; }

        public string CurrencyCode { get; set; }

        public long PreciseAmount { get; set; }
        public HighPrecisionMoney()
        {
            this.Type = IMoneyType.FindEnum("highPrecision");
        }
    }
}

namespace commercetools.Sdk.Api.Models.Common
{

    public partial class CentPrecisionMoney : ICentPrecisionMoney
    {
        public long CentAmount { get; set; }

        public string CurrencyCode { get; set; }

        public IMoneyType Type { get; set; }

        public int FractionDigits { get; set; }
        public CentPrecisionMoney()
        {
            this.Type = IMoneyType.FindEnum("centPrecision");
        }
    }
}

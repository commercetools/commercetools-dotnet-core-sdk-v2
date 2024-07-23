namespace commercetools.Sdk.Api.Models.Common
{

    public partial class CentPrecisionMoneyDraft : ICentPrecisionMoneyDraft
    {
        public long CentAmount { get; set; }

        public string CurrencyCode { get; set; }

        public IMoneyType Type { get; set; }

        public int? FractionDigits { get; set; }
        public CentPrecisionMoneyDraft()
        {
            this.Type = IMoneyType.FindEnum("centPrecision");
        }
    }
}

namespace commercetools.Sdk.ImportApi.Models.Common
{
    public partial class Money : IMoney
    {
        public IMoneyType Type { get; set; }

        public int? FractionDigits { get; set; }

        public long CentAmount { get; set; }

        public string CurrencyCode { get; set; }
        public Money()
        {
            this.Type = IMoneyType.FindEnum("centPrecision");
        }
    }
}

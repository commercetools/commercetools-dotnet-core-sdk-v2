namespace commercetools.Sdk.HistoryApi.Models.Common
{
    public partial class Money : IMoney
    {
        public string CurrencyCode { get; set; }

        public int CentAmount { get; set; }

        public int FractionDigits { get; set; }

        public IMoneyType Type { get; set; }
    }
}

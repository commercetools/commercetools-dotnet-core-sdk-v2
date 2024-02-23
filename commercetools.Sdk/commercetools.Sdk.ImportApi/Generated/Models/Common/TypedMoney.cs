namespace commercetools.Sdk.ImportApi.Models.Common
{

    public partial class TypedMoney : ITypedMoney
    {
        public IMoneyType Type { get; set; }

        public int? FractionDigits { get; set; }

        public long CentAmount { get; set; }

        public string CurrencyCode { get; set; }
    }
}

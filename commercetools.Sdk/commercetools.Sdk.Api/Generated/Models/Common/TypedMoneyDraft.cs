namespace commercetools.Api.Models.Common
{
    public partial class TypedMoneyDraft : ITypedMoneyDraft
    {
        public long CentAmount { get; set;}
        
        public string CurrencyCode { get; set;}
        
        public IMoneyType Type { get; set;}
        
        public int? FractionDigits { get; set;}
    }
}

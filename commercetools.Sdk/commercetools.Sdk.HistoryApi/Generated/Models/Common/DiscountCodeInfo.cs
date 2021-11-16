namespace commercetools.HistoryApi.Models.Common
{
    public partial class DiscountCodeInfo : IDiscountCodeInfo
    {
        public IReference DiscountCode { get; set;}
        
        public IDiscountCodeState State { get; set;}
    }
}

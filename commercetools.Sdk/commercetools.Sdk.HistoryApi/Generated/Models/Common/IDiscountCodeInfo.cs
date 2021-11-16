using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Common.DiscountCodeInfo))]
    public partial interface IDiscountCodeInfo 
    {
        IReference DiscountCode { get; set;}
        
        IDiscountCodeState State { get; set;}
    }
}

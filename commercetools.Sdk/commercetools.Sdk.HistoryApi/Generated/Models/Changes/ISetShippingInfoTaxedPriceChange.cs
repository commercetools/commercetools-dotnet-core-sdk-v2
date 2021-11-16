using commercetools.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.SetShippingInfoTaxedPriceChange))]
    public partial interface ISetShippingInfoTaxedPriceChange : IChange
    {
        new string Type { get; set;}
        
        new string Change { get; set;}
        
        ITaxedPrice NextValue { get; set;}
        
        ITaxedPrice PreviousValue { get; set;}
    }
}

using commercetools.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.SetLineItemTaxedPriceChange))]
    public partial interface ISetLineItemTaxedPriceChange : IChange
    {
        new string Type { get; set;}
        
        new string Change { get; set;}
        
        ILocalizedString LineItem { get; set;}
        
        string LineItemId { get; set;}
        
        ITaxedItemPrice NextValue { get; set;}
        
        ITaxedItemPrice PreviousValue { get; set;}
    }
}

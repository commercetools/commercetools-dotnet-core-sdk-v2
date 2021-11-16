using commercetools.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.SetLineItemProductSlugChange))]
    public partial interface ISetLineItemProductSlugChange : IChange
    {
        new string Type { get; set;}
        
        new string Change { get; set;}
        
        ILocalizedString LineItem { get; set;}
        
        string Variant { get; set;}
        
        ILocalizedString NextValue { get; set;}
        
        ILocalizedString PreviousValue { get; set;}
    }
}

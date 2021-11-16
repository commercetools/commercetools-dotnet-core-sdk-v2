using commercetools.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.SetLineItemDistributionChannelChange))]
    public partial interface ISetLineItemDistributionChannelChange : IChange
    {
        new string Type { get; set;}
        
        new string Change { get; set;}
        
        ILocalizedString LineItem { get; set;}
        
        string Variant { get; set;}
        
        IReference NextValue { get; set;}
        
        IReference PreviousValue { get; set;}
    }
}

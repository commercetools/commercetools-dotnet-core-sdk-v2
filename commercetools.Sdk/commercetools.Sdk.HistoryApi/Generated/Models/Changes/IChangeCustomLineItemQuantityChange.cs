using commercetools.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.ChangeCustomLineItemQuantityChange))]
    public partial interface IChangeCustomLineItemQuantityChange : IChange
    {
        new string Type { get; set;}
        
        new string Change { get; set;}
        
        ILocalizedString CustomLineItem { get; set;}
        
        string CustomLineItemId { get; set;}
        
        int NextValue { get; set;}
        
        int PreviousValue { get; set;}
    }
}

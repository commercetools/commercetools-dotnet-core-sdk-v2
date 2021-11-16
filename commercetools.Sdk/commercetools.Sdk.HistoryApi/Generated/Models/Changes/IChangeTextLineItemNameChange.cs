using commercetools.HistoryApi.Models.ChangeValues;
using commercetools.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.ChangeTextLineItemNameChange))]
    public partial interface IChangeTextLineItemNameChange : IChange
    {
        new string Type { get; set;}
        
        new string Change { get; set;}
        
        ITextLineItemValue TextLineItem { get; set;}
        
        ILocalizedString NextValue { get; set;}
        
        ILocalizedString PreviousValue { get; set;}
    }
}

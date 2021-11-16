using commercetools.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.AddTextLineItemChange))]
    public partial interface IAddTextLineItemChange : IChange
    {
        new string Type { get; set;}
        
        new string Change { get; set;}
        
        ITextLineItem NextValue { get; set;}
    }
}

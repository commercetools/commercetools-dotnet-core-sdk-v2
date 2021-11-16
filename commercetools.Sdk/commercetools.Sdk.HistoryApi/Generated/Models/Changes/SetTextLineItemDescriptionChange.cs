using commercetools.HistoryApi.Models.ChangeValues;
using commercetools.HistoryApi.Models.Common;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class SetTextLineItemDescriptionChange : ISetTextLineItemDescriptionChange
    {
        public string Type { get; set;}
        
        public string Change { get; set;}
        
        public ITextLineItemValue TextLineItem { get; set;}
        
        public ILocalizedString PreviousValue { get; set;}
        
        public ILocalizedString NextValue { get; set;}
        public SetTextLineItemDescriptionChange()
        { 
           this.Type = "SetTextLineItemDescriptionChange";
        }
    }
}

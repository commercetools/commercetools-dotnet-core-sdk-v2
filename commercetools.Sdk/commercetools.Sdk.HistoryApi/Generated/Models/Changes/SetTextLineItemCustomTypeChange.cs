using commercetools.HistoryApi.Models.ChangeValues;
using commercetools.HistoryApi.Models.Common;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class SetTextLineItemCustomTypeChange : ISetTextLineItemCustomTypeChange
    {
        public string Type { get; set;}
        
        public string Change { get; set;}
        
        public ITextLineItemValue TextLineItem { get; set;}
        
        public ICustomFields NextValue { get; set;}
        
        public ICustomFields PreviousValue { get; set;}
        public SetTextLineItemCustomTypeChange()
        { 
           this.Type = "SetTextLineItemCustomTypeChange";
        }
    }
}

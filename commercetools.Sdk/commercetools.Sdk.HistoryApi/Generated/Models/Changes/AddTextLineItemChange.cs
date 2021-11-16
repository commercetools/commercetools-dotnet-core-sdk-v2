using commercetools.HistoryApi.Models.Common;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class AddTextLineItemChange : IAddTextLineItemChange
    {
        public string Type { get; set;}
        
        public string Change { get; set;}
        
        public ITextLineItem NextValue { get; set;}
        public AddTextLineItemChange()
        { 
           this.Type = "AddTextLineItemChange";
        }
    }
}

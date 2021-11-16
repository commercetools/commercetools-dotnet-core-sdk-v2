using commercetools.HistoryApi.Models.Common;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class SetOrderLineItemCustomTypeChange : ISetOrderLineItemCustomTypeChange
    {
        public string Type { get; set;}
        
        public string Change { get; set;}
        
        public ILocalizedString LineItem { get; set;}
        
        public string Variant { get; set;}
        
        public ICustomFields NextValue { get; set;}
        
        public ICustomFields PreviousValue { get; set;}
        public SetOrderLineItemCustomTypeChange()
        { 
           this.Type = "SetOrderLineItemCustomTypeChange";
        }
    }
}

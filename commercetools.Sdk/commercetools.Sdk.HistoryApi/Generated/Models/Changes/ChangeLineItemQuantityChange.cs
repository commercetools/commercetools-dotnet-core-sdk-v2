using commercetools.HistoryApi.Models.Common;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class ChangeLineItemQuantityChange : IChangeLineItemQuantityChange
    {
        public string Type { get; set;}
        
        public string Change { get; set;}
        
        public ILocalizedString LineItem { get; set;}
        
        public string LineItemId { get; set;}
        
        public int NextValue { get; set;}
        
        public int PreviousValue { get; set;}
        public ChangeLineItemQuantityChange()
        { 
           this.Type = "ChangeLineItemQuantityChange";
        }
    }
}

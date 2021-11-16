using commercetools.HistoryApi.Models.Common;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class AddShoppingListLineItemChange : IAddShoppingListLineItemChange
    {
        public string Type { get; set;}
        
        public string Change { get; set;}
        
        public ILineItem PreviousValue { get; set;}
        
        public ILineItem NextValue { get; set;}
        public AddShoppingListLineItemChange()
        { 
           this.Type = "AddShoppingListLineItemChange";
        }
    }
}

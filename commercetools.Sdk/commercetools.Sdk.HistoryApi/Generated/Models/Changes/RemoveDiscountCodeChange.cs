using commercetools.HistoryApi.Models.Common;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class RemoveDiscountCodeChange : IRemoveDiscountCodeChange
    {
        public string Type { get; set;}
        
        public string Change { get; set;}
        
        public IDiscountCodeInfo PreviousValue { get; set;}
        public RemoveDiscountCodeChange()
        { 
           this.Type = "RemoveDiscountCodeChange";
        }
    }
}

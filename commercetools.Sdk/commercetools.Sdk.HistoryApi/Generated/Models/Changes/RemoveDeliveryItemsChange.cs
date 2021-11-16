using commercetools.HistoryApi.Models.Common;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class RemoveDeliveryItemsChange : IRemoveDeliveryItemsChange
    {
        public string Type { get; set;}
        
        public string Change { get; set;}
        
        public IDelivery PreviousValue { get; set;}
        public RemoveDeliveryItemsChange()
        { 
           this.Type = "RemoveDeliveryItemsChange";
        }
    }
}

using commercetools.HistoryApi.Models.ChangeValues;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class AddDeliveryChange : IAddDeliveryChange
    {
        public string Type { get; set;}
        
        public string Change { get; set;}
        
        public IDeliveryChangeValue NextValue { get; set;}
        
        public IDeliveryChangeValue PreviousValue { get; set;}
        public AddDeliveryChange()
        { 
           this.Type = "AddDeliveryChange";
        }
    }
}

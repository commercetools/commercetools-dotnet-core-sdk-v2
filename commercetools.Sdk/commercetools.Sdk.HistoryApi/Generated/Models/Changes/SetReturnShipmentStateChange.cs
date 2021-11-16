using commercetools.HistoryApi.Models.Common;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class SetReturnShipmentStateChange : ISetReturnShipmentStateChange
    {
        public string Type { get; set;}
        
        public string Change { get; set;}
        
        public IReturnShipmentState NextValue { get; set;}
        
        public IReturnShipmentState PreviousValue { get; set;}
        public SetReturnShipmentStateChange()
        { 
           this.Type = "SetReturnShipmentStateChange";
        }
    }
}

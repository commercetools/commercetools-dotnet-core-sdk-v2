using commercetools.Api.Models.Orders;
using System.Collections.Generic;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class StagedOrderAddParcelToDeliveryAction : IStagedOrderAddParcelToDeliveryAction
    {
        public string Action { get; set;}
        
        public string DeliveryId { get; set;}
        
        public IParcelMeasurements Measurements { get; set;}
        
        public ITrackingData TrackingData { get; set;}
        
        public List<IDeliveryItem> Items { get; set;}
        public StagedOrderAddParcelToDeliveryAction()
        { 
           this.Action = "addParcelToDelivery";
        }
    }
}

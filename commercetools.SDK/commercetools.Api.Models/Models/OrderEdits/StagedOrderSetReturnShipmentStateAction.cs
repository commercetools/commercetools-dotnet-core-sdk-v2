using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("setReturnShipmentState")]
    public class StagedOrderSetReturnShipmentStateAction : StagedOrderUpdateAction
    {
        public string ReturnItemId { get; set;}
        
        public string ShipmentState { get; set;}
        
        public ReturnShipmentState ShipmentStateAsEnum => this.ShipmentState.GetEnum<ReturnShipmentState>();
    }
}

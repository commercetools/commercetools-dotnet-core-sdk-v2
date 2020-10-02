using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("setReturnShipmentState")]
    public partial class StagedOrderSetReturnShipmentStateAction : StagedOrderUpdateAction
    {
        public string ReturnItemId { get; set;}
        
        public string ShipmentState { get; set;}
        
        [JsonIgnore]
        public ReturnShipmentState ShipmentStateAsEnum => this.ShipmentState.GetEnum<ReturnShipmentState>();
        public StagedOrderSetReturnShipmentStateAction()
        { 
           this.Action = "setReturnShipmentState";
        }
    }
}

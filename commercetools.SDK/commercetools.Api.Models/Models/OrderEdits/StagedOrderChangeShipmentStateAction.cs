using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("changeShipmentState")]
    public partial class StagedOrderChangeShipmentStateAction : StagedOrderUpdateAction
    {
        public string ShipmentState { get; set;}
        
        [JsonIgnore]
        public ShipmentState ShipmentStateAsEnum => this.ShipmentState.GetEnum<ShipmentState>();
        public StagedOrderChangeShipmentStateAction()
        { 
           this.Action = "changeShipmentState";
        }
    }
}

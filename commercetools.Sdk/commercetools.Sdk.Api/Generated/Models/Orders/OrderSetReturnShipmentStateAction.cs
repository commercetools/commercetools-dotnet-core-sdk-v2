using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    public  partial class OrderSetReturnShipmentStateAction : IOrderSetReturnShipmentStateAction
    {
        public string Action { get; set;}
        
        public string ReturnItemId { get; set;}
        
        public string ShipmentState { get; set;}
        
        [JsonIgnore]
        public ReturnShipmentState ShipmentStateAsEnum => this.ShipmentState.GetEnum<ReturnShipmentState>();
        public OrderSetReturnShipmentStateAction()
        { 
           this.Action = "setReturnShipmentState";
        }
    }
}

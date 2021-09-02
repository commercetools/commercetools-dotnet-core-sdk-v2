using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    public partial class OrderChangeShipmentStateAction : IOrderChangeShipmentStateAction
    {
        public string Action { get; set; }

        public IShipmentState ShipmentState { get; set; }
        public OrderChangeShipmentStateAction()
        {
            this.Action = "changeShipmentState";
        }
    }
}

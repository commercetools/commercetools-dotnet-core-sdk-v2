using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.OrderEdits
{
    public class StagedOrderSetReturnShipmentStateAction : StagedOrderUpdateAction
    {
        public string ReturnItemId { get; set;}
        
        public ReturnShipmentState ShipmentState { get; set;}
    }
}

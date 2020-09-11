using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Orders
{
    public class ReturnItemDraft 
    {
        public long Quantity { get; set;}
        
        public string LineItemId { get; set;}
        
        public string CustomLineItemId { get; set;}
        
        public string Comment { get; set;}
        
        public ReturnShipmentState ShipmentState { get; set;}
    }
}

using commercetools.Api.Models.Common;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.OrderEdits
{
    public class StagedOrderSetDeliveryAddressAction : StagedOrderUpdateAction
    {
        public string DeliveryId { get; set;}
        
        public Address Address { get; set;}
    }
}

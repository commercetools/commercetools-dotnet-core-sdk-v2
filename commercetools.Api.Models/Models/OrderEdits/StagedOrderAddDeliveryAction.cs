using commercetools.Api.Models.Common;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.OrderEdits
{
    public class StagedOrderAddDeliveryAction : StagedOrderUpdateAction
    {
        public List<DeliveryItem> Items { get; set;}
        
        public Address Address { get; set;}
        
        public List<ParcelDraft> Parcels { get; set;}
    }
}

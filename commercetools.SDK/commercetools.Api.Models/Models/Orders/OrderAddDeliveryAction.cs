using commercetools.Api.Models.Common;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DiscriminatorValue("addDelivery")]
    public class OrderAddDeliveryAction : OrderUpdateAction
    {
        public List<DeliveryItem> Items { get; set;}
        
        public Address Address { get; set;}
        
        public List<ParcelDraft> Parcels { get; set;}
    }
}

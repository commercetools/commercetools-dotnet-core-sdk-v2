using commercetools.Api.Models.Common;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("addDelivery")]
    public class StagedOrderAddDeliveryAction : StagedOrderUpdateAction
    {
        public List<DeliveryItem> Items { get; set;}
        
        public Address Address { get; set;}
        
        public List<ParcelDraft> Parcels { get; set;}
    }
}

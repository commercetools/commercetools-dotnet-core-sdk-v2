using commercetools.Api.Models.Common;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DiscriminatorValue("addDelivery")]
    public partial class OrderAddDeliveryAction : OrderUpdateAction
    {
        public List<DeliveryItem> Items { get; set;}
        
        public Address Address { get; set;}
        
        public List<ParcelDraft> Parcels { get; set;}
        public OrderAddDeliveryAction()
        { 
           this.Action = "addDelivery";
        }
    }
}

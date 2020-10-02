using commercetools.Api.Models.Common;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DiscriminatorValue("setDeliveryAddress")]
    public partial class OrderSetDeliveryAddressAction : OrderUpdateAction
    {
        public string DeliveryId { get; set;}
        
        public Address Address { get; set;}
        public OrderSetDeliveryAddressAction()
        { 
           this.Action = "setDeliveryAddress";
        }
    }
}

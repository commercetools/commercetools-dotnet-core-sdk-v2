using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DiscriminatorValue("removeDelivery")]
    public partial class OrderRemoveDeliveryAction : OrderUpdateAction
    {
        public string DeliveryId { get; set;}
        public OrderRemoveDeliveryAction()
        { 
           this.Action = "removeDelivery";
        }
    }
}

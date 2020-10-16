using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DiscriminatorValue("removeParcelFromDelivery")]
    public partial class OrderRemoveParcelFromDeliveryAction : OrderUpdateAction
    {
        public string ParcelId { get; set;}
        public OrderRemoveParcelFromDeliveryAction()
        { 
           this.Action = "removeParcelFromDelivery";
        }
    }
}

using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    public partial class OrderRemoveParcelFromDeliveryAction : IOrderRemoveParcelFromDeliveryAction
    {
        public string Action { get; set;}
        
        public string ParcelId { get; set;}
        public OrderRemoveParcelFromDeliveryAction()
        { 
           this.Action = "removeParcelFromDelivery";
        }
    }
}

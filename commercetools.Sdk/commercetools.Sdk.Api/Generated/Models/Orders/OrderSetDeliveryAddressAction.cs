using commercetools.Api.Models.Common;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    public partial class OrderSetDeliveryAddressAction : IOrderSetDeliveryAddressAction
    {
        public string Action { get; set;}
        
        public string DeliveryId { get; set;}
        
        public IBaseAddress Address { get; set;}
        public OrderSetDeliveryAddressAction()
        { 
           this.Action = "setDeliveryAddress";
        }
    }
}

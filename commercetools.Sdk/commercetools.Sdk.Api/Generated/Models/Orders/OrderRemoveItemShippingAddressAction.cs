using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    public partial class OrderRemoveItemShippingAddressAction : IOrderRemoveItemShippingAddressAction
    {
        public string Action { get; set;}
        
        public string AddressKey { get; set;}
        public OrderRemoveItemShippingAddressAction()
        { 
           this.Action = "removeItemShippingAddress";
        }
    }
}

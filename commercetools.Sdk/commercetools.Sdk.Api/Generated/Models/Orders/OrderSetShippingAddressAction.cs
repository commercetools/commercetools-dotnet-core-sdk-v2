using commercetools.Api.Models.Common;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    public  partial class OrderSetShippingAddressAction : IOrderSetShippingAddressAction
    {
        public string Action { get; set;}
        
        public IAddress Address { get; set;}
        public OrderSetShippingAddressAction()
        { 
           this.Action = "setShippingAddress";
        }
    }
}

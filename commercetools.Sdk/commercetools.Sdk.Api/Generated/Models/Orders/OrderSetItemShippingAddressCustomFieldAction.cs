using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    public partial class OrderSetItemShippingAddressCustomFieldAction : IOrderSetItemShippingAddressCustomFieldAction
    {
        public string Action { get; set;}
        
        public string AddressKey { get; set;}
        
        public string Name { get; set;}
        
        public Object Value { get; set;}
        public OrderSetItemShippingAddressCustomFieldAction()
        { 
           this.Action = "setItemShippingAddressCustomField";
        }
    }
}

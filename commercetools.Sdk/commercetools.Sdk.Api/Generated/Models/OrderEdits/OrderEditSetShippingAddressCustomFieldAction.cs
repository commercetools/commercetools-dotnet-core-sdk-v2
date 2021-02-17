using commercetools.Api.Models.OrderEdits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class OrderEditSetShippingAddressCustomFieldAction : IOrderEditSetShippingAddressCustomFieldAction
    {
        public string Action { get; set;}
        
        public string Name { get; set;}
        
        public Object Value { get; set;}
        public OrderEditSetShippingAddressCustomFieldAction()
        { 
           this.Action = "setShippingAddressCustomField";
        }
    }
}

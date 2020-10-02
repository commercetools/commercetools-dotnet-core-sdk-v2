using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DiscriminatorValue("setCustomField")]
    public partial class OrderSetCustomFieldAction : OrderUpdateAction
    {
        public string Name { get; set;}
        
        public Object Value { get; set;}
        public OrderSetCustomFieldAction()
        { 
           this.Action = "setCustomField";
        }
    }
}

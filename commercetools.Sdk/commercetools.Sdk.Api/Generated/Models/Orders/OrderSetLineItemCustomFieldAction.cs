using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    public partial class OrderSetLineItemCustomFieldAction : IOrderSetLineItemCustomFieldAction
    {
        public string Action { get; set;}
        
        public string LineItemId { get; set;}
        
        public string Name { get; set;}
        
        public Object Value { get; set;}
        public OrderSetLineItemCustomFieldAction()
        { 
           this.Action = "setLineItemCustomField";
        }
    }
}

using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DiscriminatorValue("setCustomLineItemCustomField")]
    public partial class OrderSetCustomLineItemCustomFieldAction : OrderUpdateAction
    {
        public string CustomLineItemId { get; set;}
        
        public string Name { get; set;}
        
        public Object Value { get; set;}
        public OrderSetCustomLineItemCustomFieldAction()
        { 
           this.Action = "setCustomLineItemCustomField";
        }
    }
}

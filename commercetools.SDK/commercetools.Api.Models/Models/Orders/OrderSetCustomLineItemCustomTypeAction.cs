using commercetools.Api.Models.Orders;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DiscriminatorValue("setCustomLineItemCustomType")]
    public partial class OrderSetCustomLineItemCustomTypeAction : OrderUpdateAction
    {
        public string CustomLineItemId { get; set;}
        
        public TypeResourceIdentifier Type { get; set;}
        
        public FieldContainer Fields { get; set;}
        public OrderSetCustomLineItemCustomTypeAction()
        { 
           this.Action = "setCustomLineItemCustomType";
        }
    }
}

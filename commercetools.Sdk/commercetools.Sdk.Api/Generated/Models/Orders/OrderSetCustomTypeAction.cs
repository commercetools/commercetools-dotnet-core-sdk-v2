using commercetools.Api.Models.Orders;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DiscriminatorValue("setCustomType")]
    public partial class OrderSetCustomTypeAction : OrderUpdateAction
    {
        public TypeResourceIdentifier Type { get; set;}
        
        public FieldContainer Fields { get; set;}
        public OrderSetCustomTypeAction()
        { 
           this.Action = "setCustomType";
        }
    }
}

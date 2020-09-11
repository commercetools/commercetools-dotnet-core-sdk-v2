using commercetools.Api.Models.OrderEdits;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.OrderEdits
{
    public class OrderEditSetCustomFieldAction : OrderEditUpdateAction
    {
        public string Name { get; set;}
        
        public Object Value { get; set;}
    }
}

using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.OrderEdits
{
    public class StagedOrderSetCustomFieldAction : StagedOrderUpdateAction
    {
        public string Name { get; set;}
        
        public Object Value { get; set;}
    }
}

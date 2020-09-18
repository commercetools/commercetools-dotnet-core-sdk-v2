using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("setCustomerId")]
    public class StagedOrderSetCustomerIdAction : StagedOrderUpdateAction
    {
        public string CustomerId { get; set;}
    }
}

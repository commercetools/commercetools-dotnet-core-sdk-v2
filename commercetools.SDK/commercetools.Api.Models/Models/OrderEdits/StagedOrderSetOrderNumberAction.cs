using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("setOrderNumber")]
    public class StagedOrderSetOrderNumberAction : StagedOrderUpdateAction
    {
        public string OrderNumber { get; set;}
    }
}

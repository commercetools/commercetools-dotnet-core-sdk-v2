using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("addDiscountCode")]
    public class StagedOrderAddDiscountCodeAction : StagedOrderUpdateAction
    {
        public string Code { get; set;}
    }
}

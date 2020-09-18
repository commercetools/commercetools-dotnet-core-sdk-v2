using commercetools.Api.Models.DiscountCodes;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("removeDiscountCode")]
    public class StagedOrderRemoveDiscountCodeAction : StagedOrderUpdateAction
    {
        public DiscountCodeReference DiscountCode { get; set;}
    }
}

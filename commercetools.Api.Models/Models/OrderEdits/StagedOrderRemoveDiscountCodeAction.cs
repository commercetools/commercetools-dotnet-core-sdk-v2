using commercetools.Api.Models.DiscountCodes;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.OrderEdits
{
    public class StagedOrderRemoveDiscountCodeAction : StagedOrderUpdateAction
    {
        public DiscountCodeReference DiscountCode { get; set;}
    }
}

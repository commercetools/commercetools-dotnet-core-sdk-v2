using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.OrderEdits
{
    public class StagedOrderSetShippingMethodTaxRateAction : StagedOrderUpdateAction
    {
        public ExternalTaxRateDraft ExternalTaxRate { get; set;}
    }
}

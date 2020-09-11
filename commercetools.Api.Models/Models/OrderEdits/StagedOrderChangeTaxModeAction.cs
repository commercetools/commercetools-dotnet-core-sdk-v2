using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.OrderEdits
{
    public class StagedOrderChangeTaxModeAction : StagedOrderUpdateAction
    {
        public TaxMode TaxMode { get; set;}
    }
}

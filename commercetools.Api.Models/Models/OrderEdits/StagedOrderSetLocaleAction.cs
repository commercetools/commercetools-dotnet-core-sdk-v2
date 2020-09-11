using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.OrderEdits
{
    public class StagedOrderSetLocaleAction : StagedOrderUpdateAction
    {
        public string Locale { get; set;}
    }
}

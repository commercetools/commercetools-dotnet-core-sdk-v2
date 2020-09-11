using commercetools.Api.Models.OrderEdits;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.OrderEdits
{
    public class OrderEditAddStagedActionAction : OrderEditUpdateAction
    {
        public StagedOrderUpdateAction StagedAction { get; set;}
    }
}

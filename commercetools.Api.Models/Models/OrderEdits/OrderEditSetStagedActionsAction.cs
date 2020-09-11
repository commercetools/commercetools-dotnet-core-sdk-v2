using commercetools.Api.Models.OrderEdits;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.OrderEdits
{
    public class OrderEditSetStagedActionsAction : OrderEditUpdateAction
    {
        public List<StagedOrderUpdateAction> StagedActions { get; set;}
    }
}

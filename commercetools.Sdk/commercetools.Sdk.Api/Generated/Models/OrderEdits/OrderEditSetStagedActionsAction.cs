using commercetools.Sdk.Api.Models.OrderEdits;
using commercetools.Sdk.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.OrderEdits
{

    public partial class OrderEditSetStagedActionsAction : IOrderEditSetStagedActionsAction
    {
        public string Action { get; set; }

        public IList<IStagedOrderUpdateAction> StagedActions { get; set; }
        public IEnumerable<IStagedOrderUpdateAction> StagedActionsEnumerable { set => StagedActions = value.ToList(); }

        public OrderEditSetStagedActionsAction()
        {
            this.Action = "setStagedActions";
        }
    }
}

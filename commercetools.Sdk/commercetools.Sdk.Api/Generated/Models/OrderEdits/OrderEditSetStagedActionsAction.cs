using commercetools.Api.Models.Orders;
using System.Collections.Generic;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class OrderEditSetStagedActionsAction : IOrderEditSetStagedActionsAction
    {
        public string Action { get; set; }

        public List<IStagedOrderUpdateAction> StagedActions { get; set; }
        public OrderEditSetStagedActionsAction()
        {
            this.Action = "setStagedActions";
        }
    }
}

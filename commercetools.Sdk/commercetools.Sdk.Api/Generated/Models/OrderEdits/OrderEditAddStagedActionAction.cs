using commercetools.Sdk.Api.Models.Orders;


namespace commercetools.Sdk.Api.Models.OrderEdits
{

    public partial class OrderEditAddStagedActionAction : IOrderEditAddStagedActionAction
    {
        public string Action { get; set; }

        public IStagedOrderUpdateAction StagedAction { get; set; }
        public OrderEditAddStagedActionAction()
        {
            this.Action = "addStagedAction";
        }
    }
}

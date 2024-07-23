using commercetools.Sdk.Api.Models.Orders;


namespace commercetools.Sdk.Api.Models.OrderEdits
{

    public partial class StagedOrderChangeOrderStateAction : IStagedOrderChangeOrderStateAction
    {
        public string Action { get; set; }

        public IOrderState OrderState { get; set; }
        public StagedOrderChangeOrderStateAction()
        {
            this.Action = "changeOrderState";
        }
    }
}

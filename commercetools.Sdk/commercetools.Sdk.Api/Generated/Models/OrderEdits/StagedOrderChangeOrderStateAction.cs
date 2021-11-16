using commercetools.Api.Models.Orders;


namespace commercetools.Api.Models.OrderEdits
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

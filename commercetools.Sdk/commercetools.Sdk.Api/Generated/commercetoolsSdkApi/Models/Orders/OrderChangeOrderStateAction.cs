namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class OrderChangeOrderStateAction : IOrderChangeOrderStateAction
    {
        public string Action { get; set; }

        public IOrderState OrderState { get; set; }
        public OrderChangeOrderStateAction()
        {
            this.Action = "changeOrderState";
        }
    }
}

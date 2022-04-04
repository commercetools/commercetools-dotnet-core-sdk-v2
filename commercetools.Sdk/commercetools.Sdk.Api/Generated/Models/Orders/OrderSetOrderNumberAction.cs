namespace commercetools.Sdk.Api.Models.Orders
{
    public partial class OrderSetOrderNumberAction : IOrderSetOrderNumberAction
    {
        public string Action { get; set; }

        public string OrderNumber { get; set; }
        public OrderSetOrderNumberAction()
        {
            this.Action = "setOrderNumber";
        }
    }
}

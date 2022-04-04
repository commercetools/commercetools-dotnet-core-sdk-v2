using commercetools.Sdk.Api.Models.Carts;


namespace commercetools.Sdk.Api.Models.Orders
{
    public partial class OrderSetLineItemShippingDetailsAction : IOrderSetLineItemShippingDetailsAction
    {
        public string Action { get; set; }

        public string LineItemId { get; set; }

        public IItemShippingDetailsDraft ShippingDetails { get; set; }
        public OrderSetLineItemShippingDetailsAction()
        {
            this.Action = "setLineItemShippingDetails";
        }
    }
}

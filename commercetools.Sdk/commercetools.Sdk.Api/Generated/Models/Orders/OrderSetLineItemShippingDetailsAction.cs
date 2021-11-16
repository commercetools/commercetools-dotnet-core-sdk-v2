using commercetools.Api.Models.Carts;


namespace commercetools.Api.Models.Orders
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

using commercetools.Sdk.Api.Models.Carts;


namespace commercetools.Sdk.Api.Models.Orders
{
    public partial class OrderSetCustomLineItemShippingDetailsAction : IOrderSetCustomLineItemShippingDetailsAction
    {
        public string Action { get; set; }

        public string CustomLineItemId { get; set; }

        public IItemShippingDetailsDraft ShippingDetails { get; set; }
        public OrderSetCustomLineItemShippingDetailsAction()
        {
            this.Action = "setCustomLineItemShippingDetails";
        }
    }
}

using commercetools.Api.Models.Carts;


namespace commercetools.Api.Models.Orders
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

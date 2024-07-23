namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartSetCustomLineItemShippingDetailsAction : ICartSetCustomLineItemShippingDetailsAction
    {
        public string Action { get; set; }

        public string CustomLineItemId { get; set; }

        public string CustomLineItemKey { get; set; }

        public IItemShippingDetailsDraft ShippingDetails { get; set; }
        public CartSetCustomLineItemShippingDetailsAction()
        {
            this.Action = "setCustomLineItemShippingDetails";
        }
    }
}

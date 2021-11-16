namespace commercetools.Api.Models.Carts
{
    public partial class CartSetLineItemTotalPriceAction : ICartSetLineItemTotalPriceAction
    {
        public string Action { get; set; }

        public string LineItemId { get; set; }

        public IExternalLineItemTotalPrice ExternalTotalPrice { get; set; }
        public CartSetLineItemTotalPriceAction()
        {
            this.Action = "setLineItemTotalPrice";
        }
    }
}

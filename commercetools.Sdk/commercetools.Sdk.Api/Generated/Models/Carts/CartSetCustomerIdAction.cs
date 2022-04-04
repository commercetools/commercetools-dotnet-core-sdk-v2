namespace commercetools.Sdk.Api.Models.Carts
{
    public partial class CartSetCustomerIdAction : ICartSetCustomerIdAction
    {
        public string Action { get; set; }

        public string CustomerId { get; set; }
        public CartSetCustomerIdAction()
        {
            this.Action = "setCustomerId";
        }
    }
}

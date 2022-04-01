namespace commercetools.Sdk.Api.Models.Carts
{
    public partial class CartSetKeyAction : ICartSetKeyAction
    {
        public string Action { get; set; }

        public string Key { get; set; }
        public CartSetKeyAction()
        {
            this.Action = "setKey";
        }
    }
}

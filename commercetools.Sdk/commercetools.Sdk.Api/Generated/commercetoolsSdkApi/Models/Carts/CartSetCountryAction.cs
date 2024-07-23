namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartSetCountryAction : ICartSetCountryAction
    {
        public string Action { get; set; }

        public string Country { get; set; }
        public CartSetCountryAction()
        {
            this.Action = "setCountry";
        }
    }
}

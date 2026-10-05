

namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartSetDirectDiscountsIgnoreCartDiscountsAction : ICartSetDirectDiscountsIgnoreCartDiscountsAction
    {
        public string Action { get; set; }

        public bool? DirectDiscountsIgnoreCartDiscounts { get; set; }
        public CartSetDirectDiscountsIgnoreCartDiscountsAction()
        {
            this.Action = "setDirectDiscountsIgnoreCartDiscounts";
        }
    }
}

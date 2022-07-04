using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Carts
{
    public partial class CartSetDirectDiscountsAction : ICartSetDirectDiscountsAction
    {
        public string Action { get; set; }

        public List<IDirectDiscountDraft> Discounts { get; set; }
        public CartSetDirectDiscountsAction()
        {
            this.Action = "setDirectDiscounts";
        }
    }
}

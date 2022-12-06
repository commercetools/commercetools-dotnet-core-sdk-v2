using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartSetDirectDiscountsAction : ICartSetDirectDiscountsAction
    {
        public string Action { get; set; }

        public IList<IDirectDiscountDraft> Discounts { get; set; }
        public IEnumerable<IDirectDiscountDraft> DiscountsEnumerable { set => Discounts = value.ToList(); }

        public CartSetDirectDiscountsAction()
        {
            this.Action = "setDirectDiscounts";
        }
    }
}

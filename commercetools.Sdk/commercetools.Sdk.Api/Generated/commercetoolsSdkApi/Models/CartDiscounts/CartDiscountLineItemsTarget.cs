

namespace commercetools.Sdk.Api.Models.CartDiscounts
{

    public partial class CartDiscountLineItemsTarget : ICartDiscountLineItemsTarget
    {
        public string Type { get; set; }

        public string Predicate { get; set; }
        public CartDiscountLineItemsTarget()
        {
            this.Type = "lineItems";
        }
    }
}

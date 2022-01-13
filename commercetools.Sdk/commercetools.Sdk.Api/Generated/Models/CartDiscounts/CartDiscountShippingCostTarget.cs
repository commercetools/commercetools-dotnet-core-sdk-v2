namespace commercetools.Api.Models.CartDiscounts
{
    public partial class CartDiscountShippingCostTarget : ICartDiscountShippingCostTarget
    {
        public string Type { get; set; }
        public CartDiscountShippingCostTarget()
        {
            this.Type = "shipping";
        }
    }
}

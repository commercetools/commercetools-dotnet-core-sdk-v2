namespace commercetools.Sdk.Api.Models.CartDiscounts
{

    public partial class CartDiscountTotalPriceTarget : ICartDiscountTotalPriceTarget
    {
        public string Type { get; set; }
        public CartDiscountTotalPriceTarget()
        {
            this.Type = "totalPrice";
        }
    }
}

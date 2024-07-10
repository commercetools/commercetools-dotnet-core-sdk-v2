using commercetools.Sdk.Api.Models.CartDiscounts;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class DirectDiscount : IDirectDiscount
    {
        public string Id { get; set; }

        public ICartDiscountValue Value { get; set; }

        public ICartDiscountTarget Target { get; set; }
    }
}

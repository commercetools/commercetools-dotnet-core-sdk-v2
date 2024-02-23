using commercetools.Sdk.Api.Models.CartDiscounts;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class DirectDiscountDraft : IDirectDiscountDraft
    {
        public ICartDiscountValue Value { get; set; }

        public ICartDiscountTarget Target { get; set; }
    }
}

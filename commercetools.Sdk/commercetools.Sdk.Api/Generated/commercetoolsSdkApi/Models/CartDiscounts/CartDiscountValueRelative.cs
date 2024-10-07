

namespace commercetools.Sdk.Api.Models.CartDiscounts
{

    public partial class CartDiscountValueRelative : ICartDiscountValueRelative
    {
        public string Type { get; set; }

        public long Permyriad { get; set; }
        public CartDiscountValueRelative()
        {
            this.Type = "relative";
        }
    }
}

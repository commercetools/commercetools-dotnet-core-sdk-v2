using commercetools.Sdk.Api.Models.CartDiscounts;
using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class DiscountedLineItemPortion : IDiscountedLineItemPortion
    {
        public ICartDiscountReference Discount { get; set; }

        public ITypedMoney DiscountedAmount { get; set; }
    }
}

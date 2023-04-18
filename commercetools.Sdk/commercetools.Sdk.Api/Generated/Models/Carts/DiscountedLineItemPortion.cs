using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class DiscountedLineItemPortion : IDiscountedLineItemPortion
    {
        public IReference Discount { get; set; }

        public ITypedMoney DiscountedAmount { get; set; }
    }
}

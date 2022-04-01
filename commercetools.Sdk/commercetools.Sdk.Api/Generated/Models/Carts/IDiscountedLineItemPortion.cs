using commercetools.Sdk.Api.Models.CartDiscounts;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.DiscountedLineItemPortion))]
    public partial interface IDiscountedLineItemPortion
    {
        ICartDiscountReference Discount { get; set; }

        ITypedMoney DiscountedAmount { get; set; }
    }
}

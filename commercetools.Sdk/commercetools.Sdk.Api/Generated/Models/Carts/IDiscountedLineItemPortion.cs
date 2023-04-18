using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.DiscountedLineItemPortion))]
    public partial interface IDiscountedLineItemPortion
    {
        IReference Discount { get; set; }

        ITypedMoney DiscountedAmount { get; set; }

    }
}

using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.CartDiscounts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountValueRelative))]
    public partial interface ICartDiscountValueRelative : ICartDiscountValue
    {
        long Permyriad { get; set; }

    }
}

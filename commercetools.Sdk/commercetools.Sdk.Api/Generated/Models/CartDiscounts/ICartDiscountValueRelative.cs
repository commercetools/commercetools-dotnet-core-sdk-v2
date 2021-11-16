using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    [DeserializeAs(typeof(commercetools.Api.Models.CartDiscounts.CartDiscountValueRelative))]
    public partial interface ICartDiscountValueRelative : ICartDiscountValue
    {
        long Permyriad { get; set;}
    }
}

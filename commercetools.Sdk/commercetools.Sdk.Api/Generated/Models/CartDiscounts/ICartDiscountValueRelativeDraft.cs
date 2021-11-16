using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    [DeserializeAs(typeof(commercetools.Api.Models.CartDiscounts.CartDiscountValueRelativeDraft))]
    public partial interface ICartDiscountValueRelativeDraft : ICartDiscountValueDraft
    {
        long Permyriad { get; set;}
    }
}

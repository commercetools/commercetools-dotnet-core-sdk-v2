using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.CartDiscounts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountValueRelativeDraft))]
    public partial interface ICartDiscountValueRelativeDraft : ICartDiscountValueDraft
    {
        long Permyriad { get; set; }
    }
}

using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.CartDiscounts
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountValueDraft))]
    [SubTypeDiscriminator("absolute", typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountValueAbsoluteDraft))]
    [SubTypeDiscriminator("fixed", typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountValueFixedDraft))]
    [SubTypeDiscriminator("giftLineItem", typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountValueGiftLineItemDraft))]
    [SubTypeDiscriminator("relative", typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountValueRelativeDraft))]
    public partial interface ICartDiscountValueDraft
    {
        string Type { get; set; }
    }
}

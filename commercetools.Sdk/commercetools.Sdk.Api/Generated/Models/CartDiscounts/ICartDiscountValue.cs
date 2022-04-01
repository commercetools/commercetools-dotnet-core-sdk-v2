using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.CartDiscounts
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountValue))]
    [SubTypeDiscriminator("absolute", typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountValueAbsolute))]
    [SubTypeDiscriminator("fixed", typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountValueFixed))]
    [SubTypeDiscriminator("giftLineItem", typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountValueGiftLineItem))]
    [SubTypeDiscriminator("relative", typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountValueRelative))]
    public partial interface ICartDiscountValue
    {
        string Type { get; set; }
    }
}

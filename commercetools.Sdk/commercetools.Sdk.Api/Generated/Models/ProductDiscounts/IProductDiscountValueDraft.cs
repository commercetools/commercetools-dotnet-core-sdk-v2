using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ProductDiscounts
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountValueDraft))]
    [SubTypeDiscriminator("absolute", typeof(commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountValueAbsoluteDraft))]
    [SubTypeDiscriminator("external", typeof(commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountValueExternalDraft))]
    [SubTypeDiscriminator("relative", typeof(commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountValueRelativeDraft))]
    public partial interface IProductDiscountValueDraft
    {
        string Type { get; set; }
    }
}

using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductDiscounts
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Api.Models.ProductDiscounts.ProductDiscountValueDraft))]
    [SubTypeDiscriminator("absolute", typeof(commercetools.Api.Models.ProductDiscounts.ProductDiscountValueAbsoluteDraft))]
    [SubTypeDiscriminator("external", typeof(commercetools.Api.Models.ProductDiscounts.ProductDiscountValueExternalDraft))]
    [SubTypeDiscriminator("relative", typeof(commercetools.Api.Models.ProductDiscounts.ProductDiscountValueRelativeDraft))]
    public partial interface IProductDiscountValueDraft 
    {
        string Type { get; set;}
    }
}

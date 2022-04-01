using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ProductDiscounts
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountValue))]
    [SubTypeDiscriminator("absolute", typeof(commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountValueAbsolute))]
    [SubTypeDiscriminator("external", typeof(commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountValueExternal))]
    [SubTypeDiscriminator("relative", typeof(commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountValueRelative))]
    public partial interface IProductDiscountValue
    {
        string Type { get; set; }
    }
}

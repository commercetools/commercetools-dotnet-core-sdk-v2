using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ProductSelections
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.ProductSelections.ProductVariantSelection))]
    [SubTypeDiscriminator("exclusion", typeof(commercetools.Sdk.Api.Models.ProductSelections.ProductVariantSelectionExclusion))]
    [SubTypeDiscriminator("inclusion", typeof(commercetools.Sdk.Api.Models.ProductSelections.ProductVariantSelectionInclusion))]
    public partial interface IProductVariantSelection
    {
        IProductVariantSelectionTypeEnum Type { get; set; }
    }
}

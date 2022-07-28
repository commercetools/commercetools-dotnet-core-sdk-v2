using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Products.ProductRevertStagedVariantChangesAction))]
    public partial interface IProductRevertStagedVariantChangesAction : IProductUpdateAction
    {
        long VariantId { get; set; }

    }
}

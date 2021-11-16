using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Api.Models.Products.ProductRevertStagedVariantChangesAction))]
    public partial interface IProductRevertStagedVariantChangesAction : IProductUpdateAction
    {
        long VariantId { get; set; }
    }
}

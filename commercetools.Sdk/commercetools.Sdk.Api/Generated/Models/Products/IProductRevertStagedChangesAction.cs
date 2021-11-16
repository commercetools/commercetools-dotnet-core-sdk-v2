using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Api.Models.Products.ProductRevertStagedChangesAction))]
    public partial interface IProductRevertStagedChangesAction : IProductUpdateAction
    {
    }
}

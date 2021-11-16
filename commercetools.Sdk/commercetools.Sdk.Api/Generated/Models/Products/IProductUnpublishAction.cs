using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Api.Models.Products.ProductUnpublishAction))]
    public partial interface IProductUnpublishAction : IProductUpdateAction
    {
    }
}

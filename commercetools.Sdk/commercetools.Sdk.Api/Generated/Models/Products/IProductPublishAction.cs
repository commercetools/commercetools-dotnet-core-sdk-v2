using commercetools.Sdk.Api.Models.Carts;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Products.ProductPublishAction))]
    public partial interface IProductPublishAction : IProductUpdateAction
    {
        IProductPublishScope Scope { get; set; }
    }
}

using commercetools.Api.Models.Carts;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Api.Models.Products.ProductPublishAction))]
    public partial interface IProductPublishAction : IProductUpdateAction
    {
        IProductPublishScope Scope { get; set; }
    }
}

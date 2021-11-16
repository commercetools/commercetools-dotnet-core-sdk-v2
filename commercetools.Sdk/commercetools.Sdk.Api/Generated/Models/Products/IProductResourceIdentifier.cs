using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Api.Models.Products.ProductResourceIdentifier))]
    public partial interface IProductResourceIdentifier : IResourceIdentifier
    {
    }
}

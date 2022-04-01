using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Products.ProductResourceIdentifier))]
    public partial interface IProductResourceIdentifier : IResourceIdentifier
    {
    }
}

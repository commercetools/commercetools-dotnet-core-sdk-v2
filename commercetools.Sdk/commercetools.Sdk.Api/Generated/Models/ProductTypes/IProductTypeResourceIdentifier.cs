using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [DeserializeAs(typeof(commercetools.Api.Models.ProductTypes.ProductTypeResourceIdentifier))]
    public partial interface IProductTypeResourceIdentifier : IResourceIdentifier
    {
    }
}

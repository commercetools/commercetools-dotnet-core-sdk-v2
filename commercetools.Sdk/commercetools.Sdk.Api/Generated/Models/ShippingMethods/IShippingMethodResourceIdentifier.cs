using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShippingMethods
{
    [DeserializeAs(typeof(commercetools.Api.Models.ShippingMethods.ShippingMethodResourceIdentifier))]
    public partial interface IShippingMethodResourceIdentifier : IResourceIdentifier
    {
    }
}

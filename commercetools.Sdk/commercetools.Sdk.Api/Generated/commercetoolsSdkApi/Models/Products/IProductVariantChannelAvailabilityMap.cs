using System.Collections.Generic;
using commercetools.Base.CustomAttributes;

namespace commercetools.Sdk.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Products.ProductVariantChannelAvailabilityMap))]
    public partial interface IProductVariantChannelAvailabilityMap : IDictionary<string, IProductVariantChannelAvailability>
    {
    }
}

using System.Collections.Generic;
using commercetools.Base.CustomAttributes;

namespace commercetools.Sdk.Api.Models.VariantAttributes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.VariantAttributes.VariantAttributesChannelAvailabilityMap))]
    public partial interface IVariantAttributesChannelAvailabilityMap : IDictionary<string, IVariantAttributesChannelAvailability>
    {
    }
}

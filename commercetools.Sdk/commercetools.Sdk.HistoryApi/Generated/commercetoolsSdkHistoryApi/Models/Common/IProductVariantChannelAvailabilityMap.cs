using System.Collections.Generic;
using commercetools.Base.CustomAttributes;

namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.ProductVariantChannelAvailabilityMap))]
    public partial interface IProductVariantChannelAvailabilityMap : IDictionary<string, IProductVariantChannelAvailability>
    {
    }
}

using commercetools.Sdk.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.ProductVariantChannelAvailabilityMap))]
    public interface IProductVariantChannelAvailabilityMap : IDictionary<string, IProductVariantChannelAvailability>
    {
    }
}

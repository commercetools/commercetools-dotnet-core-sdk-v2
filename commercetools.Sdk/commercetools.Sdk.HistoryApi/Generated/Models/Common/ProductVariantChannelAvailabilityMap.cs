using commercetools.Sdk.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class ProductVariantChannelAvailabilityMap : Dictionary<string, IProductVariantChannelAvailability>, IProductVariantChannelAvailabilityMap
    {
    }
}

using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Common
{
    public partial class ProductVariantAvailability : IProductVariantAvailability
    {
        public bool IsOnStock { get; set; }

        public int RestockableInDays { get; set; }

        public int AvailableQuantity { get; set; }

        public IProductVariantChannelAvailabilityMap Channels { get; set; }
    }
}

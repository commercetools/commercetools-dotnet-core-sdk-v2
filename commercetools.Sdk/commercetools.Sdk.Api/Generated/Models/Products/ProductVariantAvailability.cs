using commercetools.Sdk.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Products
{

    public partial class ProductVariantAvailability : IProductVariantAvailability
    {
        public IProductVariantChannelAvailabilityMap Channels { get; set; }

        public bool? IsOnStock { get; set; }

        public long? RestockableInDays { get; set; }

        public long? AvailableQuantity { get; set; }

        public string Id { get; set; }

        public long? Version { get; set; }
    }
}

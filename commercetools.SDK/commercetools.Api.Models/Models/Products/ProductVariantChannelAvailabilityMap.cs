using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    public class ProductVariantChannelAvailabilityMap : Dictionary<string, ProductVariantChannelAvailability>
    {
        public ProductVariantChannelAvailabilityMap() : base()
        {
        }
    }
}

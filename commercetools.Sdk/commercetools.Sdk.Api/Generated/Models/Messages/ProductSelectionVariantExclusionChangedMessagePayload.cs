using commercetools.Sdk.Api.Models.Messages;
using commercetools.Sdk.Api.Models.ProductSelections;
using commercetools.Sdk.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class ProductSelectionVariantExclusionChangedMessagePayload : IProductSelectionVariantExclusionChangedMessagePayload
    {
        public string Type { get; set; }

        public IProductReference Product { get; set; }

        public IProductVariantExclusion OldVariantExclusion { get; set; }

        public IProductVariantExclusion NewVariantExclusion { get; set; }
        public ProductSelectionVariantExclusionChangedMessagePayload()
        {
            this.Type = "ProductSelectionVariantExclusionChanged";
        }
    }
}

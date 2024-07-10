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

    public partial class ProductSelectionProductExcludedMessagePayload : IProductSelectionProductExcludedMessagePayload
    {
        public string Type { get; set; }

        public IProductReference Product { get; set; }

        public IProductVariantExclusion VariantExclusion { get; set; }
        public ProductSelectionProductExcludedMessagePayload()
        {
            this.Type = "ProductSelectionProductExcluded";
        }
    }
}

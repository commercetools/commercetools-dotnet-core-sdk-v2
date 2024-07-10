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

    public partial class ProductSelectionVariantSelectionChangedMessagePayload : IProductSelectionVariantSelectionChangedMessagePayload
    {
        public string Type { get; set; }

        public IProductReference Product { get; set; }

        public IProductVariantSelection OldVariantSelection { get; set; }

        public IProductVariantSelection NewVariantSelection { get; set; }
        public ProductSelectionVariantSelectionChangedMessagePayload()
        {
            this.Type = "ProductSelectionVariantSelectionChanged";
        }
    }
}

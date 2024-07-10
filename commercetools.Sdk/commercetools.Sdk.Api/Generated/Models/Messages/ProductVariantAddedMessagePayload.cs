using commercetools.Sdk.Api.Models.Messages;
using commercetools.Sdk.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class ProductVariantAddedMessagePayload : IProductVariantAddedMessagePayload
    {
        public string Type { get; set; }

        public IProductVariant Variant { get; set; }

        public bool Staged { get; set; }
        public ProductVariantAddedMessagePayload()
        {
            this.Type = "ProductVariantAdded";
        }
    }
}

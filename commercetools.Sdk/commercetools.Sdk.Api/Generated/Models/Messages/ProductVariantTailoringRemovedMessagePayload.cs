using commercetools.Sdk.Api.Models.Messages;
using commercetools.Sdk.Api.Models.ProductTailorings;
using commercetools.Sdk.Api.Models.Products;
using commercetools.Sdk.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class ProductVariantTailoringRemovedMessagePayload : IProductVariantTailoringRemovedMessagePayload
    {
        public string Type { get; set; }

        public IStoreKeyReference Store { get; set; }

        public string ProductKey { get; set; }

        public IProductReference Product { get; set; }

        public long VariantId { get; set; }

        public IProductVariantTailoring Variant { get; set; }
        public ProductVariantTailoringRemovedMessagePayload()
        {
            this.Type = "ProductVariantTailoringRemoved";
        }
    }
}

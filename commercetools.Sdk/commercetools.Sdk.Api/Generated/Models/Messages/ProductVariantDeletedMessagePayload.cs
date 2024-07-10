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

    public partial class ProductVariantDeletedMessagePayload : IProductVariantDeletedMessagePayload
    {
        public string Type { get; set; }

        public IProductVariant Variant { get; set; }

        public IList<string> RemovedImageUrls { get; set; }
        public IEnumerable<string> RemovedImageUrlsEnumerable { set => RemovedImageUrls = value.ToList(); }

        public ProductVariantDeletedMessagePayload()
        {
            this.Type = "ProductVariantDeleted";
        }
    }
}

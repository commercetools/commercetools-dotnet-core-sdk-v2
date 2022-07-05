using commercetools.Sdk.Api.Models.Products;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class ProductVariantDeletedMessagePayload : IProductVariantDeletedMessagePayload
    {
        public string Type { get; set; }

        public IProductVariant Variant { get; set; }

        public List<string> RemovedImageUrls { get; set; }
        public ProductVariantDeletedMessagePayload()
        {
            this.Type = "ProductVariantDeleted";
        }
    }
}

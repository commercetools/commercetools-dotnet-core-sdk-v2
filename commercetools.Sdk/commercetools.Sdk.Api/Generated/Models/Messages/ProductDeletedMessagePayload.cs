using commercetools.Sdk.Api.Models.Products;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class ProductDeletedMessagePayload : IProductDeletedMessagePayload
    {
        public string Type { get; set; }

        public List<string> RemovedImageUrls { get; set; }

        public IProductProjection CurrentProjection { get; set; }
        public ProductDeletedMessagePayload()
        {
            this.Type = "ProductDeleted";
        }
    }
}

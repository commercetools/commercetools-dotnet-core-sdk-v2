using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Products;
using System.Collections.Generic;


namespace commercetools.Api.Models.Messages
{
    public partial class ProductPublishedMessagePayload : IProductPublishedMessagePayload
    {
        public string Type { get; set; }

        public List<string> RemovedImageUrls { get; set; }

        public IProductProjection ProductProjection { get; set; }

        public IProductPublishScope Scope { get; set; }
        public ProductPublishedMessagePayload()
        {
            this.Type = "ProductPublished";
        }
    }
}

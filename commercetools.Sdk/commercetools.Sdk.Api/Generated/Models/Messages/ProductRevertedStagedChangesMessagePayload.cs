using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class ProductRevertedStagedChangesMessagePayload : IProductRevertedStagedChangesMessagePayload
    {
        public string Type { get; set; }

        public List<string> RemovedImageUrls { get; set; }
        public ProductRevertedStagedChangesMessagePayload()
        {
            this.Type = "ProductRevertedStagedChanges";
        }
    }
}

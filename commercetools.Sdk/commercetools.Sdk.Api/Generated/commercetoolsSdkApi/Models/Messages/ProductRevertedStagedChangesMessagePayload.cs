using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class ProductRevertedStagedChangesMessagePayload : IProductRevertedStagedChangesMessagePayload
    {
        public string Type { get; set; }

        public IList<string> RemovedImageUrls { get; set; }

        public IEnumerable<string> RemovedImageUrlsEnumerable { set => RemovedImageUrls = value.ToList(); }
        public ProductRevertedStagedChangesMessagePayload()
        {
            this.Type = "ProductRevertedStagedChanges";
        }
    }
}

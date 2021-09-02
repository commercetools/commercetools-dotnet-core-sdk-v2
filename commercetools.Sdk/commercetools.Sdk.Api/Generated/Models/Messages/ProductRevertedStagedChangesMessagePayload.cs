using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
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

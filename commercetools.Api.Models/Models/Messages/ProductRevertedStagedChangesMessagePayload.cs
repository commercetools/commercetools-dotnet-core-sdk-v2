using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Messages
{
    public class ProductRevertedStagedChangesMessagePayload : MessagePayload
    {
        public List<string> RemovedImageUrls { get; set;}
    }
}

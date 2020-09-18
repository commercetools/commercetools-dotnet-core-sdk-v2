using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("ProductRevertedStagedChanges")]
    public class ProductRevertedStagedChangesMessage : Message
    {
        public List<string> RemovedImageUrls { get; set;}
    }
}

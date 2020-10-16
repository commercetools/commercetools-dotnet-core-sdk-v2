using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("ProductRevertedStagedChanges")]
    public partial class ProductRevertedStagedChangesMessage : Message
    {
        public List<string> RemovedImageUrls { get; set;}
        public ProductRevertedStagedChangesMessage()
        { 
           this.Type = "ProductRevertedStagedChanges";
        }
    }
}

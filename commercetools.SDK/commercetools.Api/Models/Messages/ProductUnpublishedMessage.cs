using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("ProductUnpublished")]
    public partial class ProductUnpublishedMessage : Message
    {
        public ProductUnpublishedMessage()
        { 
           this.Type = "ProductUnpublished";
        }
    }
}

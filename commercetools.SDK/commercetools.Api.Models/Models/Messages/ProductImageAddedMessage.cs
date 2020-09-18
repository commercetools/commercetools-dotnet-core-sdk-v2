using commercetools.Api.Models.Common;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("ProductImageAdded")]
    public class ProductImageAddedMessage : Message
    {
        public long VariantId { get; set;}
        
        public Image Image { get; set;}
        
        public bool Staged { get; set;}
    }
}

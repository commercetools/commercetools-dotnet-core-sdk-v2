using commercetools.Api.Models.Common;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Messages
{
    public class ProductImageAddedMessage : Message
    {
        public long VariantId { get; set;}
        
        public Image Image { get; set;}
        
        public bool Staged { get; set;}
    }
}

using commercetools.Api.Models.Categorys;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("ProductAddedToCategory")]
    public class ProductAddedToCategoryMessagePayload : MessagePayload
    {
        public CategoryReference Category { get; set;}
        
        public bool Staged { get; set;}
    }
}

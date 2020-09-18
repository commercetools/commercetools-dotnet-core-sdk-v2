using commercetools.Api.Models.DiscountCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.DiscountCodes
{
    [Discriminator(nameof(Action))]
    public abstract class DiscountCodeUpdateAction 
    {
        public string Action { get; set;}
    }
}

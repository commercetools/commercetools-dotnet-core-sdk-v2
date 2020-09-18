using commercetools.Api.Models.OrderEdits;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [Discriminator(nameof(Type))]
    public abstract class OrderEditResult 
    {
        public string Type { get; set;}
    }
}

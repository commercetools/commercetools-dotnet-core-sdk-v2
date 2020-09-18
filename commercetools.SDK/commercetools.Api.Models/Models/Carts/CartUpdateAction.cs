using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [Discriminator(nameof(Action))]
    public abstract class CartUpdateAction 
    {
        public string Action { get; set;}
    }
}

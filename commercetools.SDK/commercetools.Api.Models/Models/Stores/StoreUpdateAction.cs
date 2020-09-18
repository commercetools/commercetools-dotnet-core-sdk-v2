using commercetools.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Stores
{
    [Discriminator(nameof(Action))]
    public abstract class StoreUpdateAction 
    {
        public string Action { get; set;}
    }
}

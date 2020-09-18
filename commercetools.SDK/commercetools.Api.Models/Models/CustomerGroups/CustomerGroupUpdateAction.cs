using commercetools.Api.Models.CustomerGroups;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.CustomerGroups
{
    [Discriminator(nameof(Action))]
    public abstract class CustomerGroupUpdateAction 
    {
        public string Action { get; set;}
    }
}

using commercetools.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [Discriminator(nameof(Action))]
    public abstract class CustomerUpdateAction 
    {
        public string Action { get; set;}
    }
}

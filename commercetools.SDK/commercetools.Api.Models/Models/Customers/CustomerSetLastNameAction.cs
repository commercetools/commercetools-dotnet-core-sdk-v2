using commercetools.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [DiscriminatorValue("setLastName")]
    public class CustomerSetLastNameAction : CustomerUpdateAction
    {
        public string LastName { get; set;}
    }
}

using commercetools.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [DiscriminatorValue("setKey")]
    public class CustomerSetKeyAction : CustomerUpdateAction
    {
        public string Key { get; set;}
    }
}

using commercetools.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [DiscriminatorValue("setCustomField")]
    public class CustomerSetCustomFieldAction : CustomerUpdateAction
    {
        public string Name { get; set;}
        
        public Object Value { get; set;}
    }
}

using commercetools.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Customers
{
    public class CustomerSetCustomFieldAction : CustomerUpdateAction
    {
        public string Name { get; set;}
        
        public Object Value { get; set;}
    }
}

using commercetools.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    public class CustomerUpdate 
    {
        public long Version { get; set;}
        
        public List<CustomerUpdateAction> Actions { get; set;}
    }
}

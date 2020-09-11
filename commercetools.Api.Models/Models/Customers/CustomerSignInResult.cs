using commercetools.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Customers
{
    public class CustomerSignInResult 
    {
        public Customer Customer { get; set;}
        
        public Object Cart { get; set;}
    }
}

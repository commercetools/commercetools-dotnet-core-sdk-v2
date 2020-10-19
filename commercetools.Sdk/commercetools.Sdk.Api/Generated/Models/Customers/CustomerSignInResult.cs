using commercetools.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;


namespace commercetools.Api.Models.Customers
{
    public partial class CustomerSignInResult 
    {
        public Customer Customer { get; set;}
        
        public Object Cart { get; set;}
    }
}

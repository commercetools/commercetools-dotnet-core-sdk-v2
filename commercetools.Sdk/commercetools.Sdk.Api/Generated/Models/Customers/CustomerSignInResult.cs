using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    public partial class CustomerSignInResult : ICustomerSignInResult
    {
        public ICustomer Customer { get; set;}
        
        public ICart Cart { get; set;}
    }
}

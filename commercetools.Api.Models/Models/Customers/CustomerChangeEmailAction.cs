using commercetools.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Customers
{
    public class CustomerChangeEmailAction : CustomerUpdateAction
    {
        public string Email { get; set;}
    }
}

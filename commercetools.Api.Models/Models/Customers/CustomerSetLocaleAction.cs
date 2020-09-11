using commercetools.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Customers
{
    public class CustomerSetLocaleAction : CustomerUpdateAction
    {
        public string Locale { get; set;}
    }
}

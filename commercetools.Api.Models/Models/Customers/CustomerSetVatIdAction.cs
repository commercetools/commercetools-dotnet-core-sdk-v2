using commercetools.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Customers
{
    public class CustomerSetVatIdAction : CustomerUpdateAction
    {
        public string VatId { get; set;}
    }
}

using commercetools.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Customers
{
    public class CustomerSetExternalIdAction : CustomerUpdateAction
    {
        public string ExternalId { get; set;}
    }
}

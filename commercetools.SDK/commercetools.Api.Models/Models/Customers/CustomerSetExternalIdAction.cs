using commercetools.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [DiscriminatorValue("setExternalId")]
    public class CustomerSetExternalIdAction : CustomerUpdateAction
    {
        public string ExternalId { get; set;}
    }
}

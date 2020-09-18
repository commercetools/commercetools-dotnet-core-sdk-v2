using commercetools.Api.Models.CustomerGroups;
using commercetools.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [DiscriminatorValue("setCustomerGroup")]
    public class CustomerSetCustomerGroupAction : CustomerUpdateAction
    {
        public CustomerGroupResourceIdentifier CustomerGroup { get; set;}
    }
}

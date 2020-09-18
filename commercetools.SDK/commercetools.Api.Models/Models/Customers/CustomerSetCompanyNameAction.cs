using commercetools.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [DiscriminatorValue("setCompanyName")]
    public class CustomerSetCompanyNameAction : CustomerUpdateAction
    {
        public string CompanyName { get; set;}
    }
}

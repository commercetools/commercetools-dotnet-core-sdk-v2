using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("setCompanyName")]
    public class MyCustomerSetCompanyNameAction : MyCustomerUpdateAction
    {
        public string CompanyName { get; set;}
    }
}

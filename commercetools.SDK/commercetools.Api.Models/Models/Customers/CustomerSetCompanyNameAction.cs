using commercetools.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [DiscriminatorValue("setCompanyName")]
    public partial class CustomerSetCompanyNameAction : CustomerUpdateAction
    {
        public string CompanyName { get; set;}
        public CustomerSetCompanyNameAction()
        { 
           this.Action = "setCompanyName";
        }
    }
}

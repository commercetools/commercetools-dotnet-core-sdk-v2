using commercetools.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    public partial class CustomerSetCompanyNameAction : ICustomerSetCompanyNameAction
    {
        public string Action { get; set;}
        
        public string CompanyName { get; set;}
        public CustomerSetCompanyNameAction()
        { 
           this.Action = "setCompanyName";
        }
    }
}

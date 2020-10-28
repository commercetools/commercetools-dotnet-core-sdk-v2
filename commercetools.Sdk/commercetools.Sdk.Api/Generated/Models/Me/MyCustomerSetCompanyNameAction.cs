using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    public partial class MyCustomerSetCompanyNameAction : IMyCustomerSetCompanyNameAction
    {
        public string Action { get; set;}
        
        public string CompanyName { get; set;}
        public MyCustomerSetCompanyNameAction()
        { 
           this.Action = "setCompanyName";
        }
    }
}

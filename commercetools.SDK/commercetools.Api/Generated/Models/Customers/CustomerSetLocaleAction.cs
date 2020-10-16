using commercetools.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [DiscriminatorValue("setLocale")]
    public partial class CustomerSetLocaleAction : CustomerUpdateAction
    {
        public string Locale { get; set;}
        public CustomerSetLocaleAction()
        { 
           this.Action = "setLocale";
        }
    }
}

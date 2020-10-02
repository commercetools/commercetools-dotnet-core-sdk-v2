using commercetools.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [DiscriminatorValue("setKey")]
    public partial class CustomerSetKeyAction : CustomerUpdateAction
    {
        public string Key { get; set;}
        public CustomerSetKeyAction()
        { 
           this.Action = "setKey";
        }
    }
}

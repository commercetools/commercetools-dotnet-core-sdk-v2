using commercetools.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [DiscriminatorValue("setMiddleName")]
    public partial class CustomerSetMiddleNameAction : CustomerUpdateAction
    {
        public string MiddleName { get; set;}
        public CustomerSetMiddleNameAction()
        { 
           this.Action = "setMiddleName";
        }
    }
}

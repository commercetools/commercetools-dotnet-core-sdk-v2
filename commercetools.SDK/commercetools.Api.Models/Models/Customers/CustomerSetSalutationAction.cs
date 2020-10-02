using commercetools.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [DiscriminatorValue("setSalutation")]
    public partial class CustomerSetSalutationAction : CustomerUpdateAction
    {
        public string Salutation { get; set;}
        public CustomerSetSalutationAction()
        { 
           this.Action = "setSalutation";
        }
    }
}

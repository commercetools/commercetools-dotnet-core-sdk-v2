using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("setSalutation")]
    public partial class MyCustomerSetSalutationAction : MyCustomerUpdateAction
    {
        public string Salutation { get; set;}
        public MyCustomerSetSalutationAction()
        { 
           this.Action = "setSalutation";
        }
    }
}

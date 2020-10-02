using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("changeEmail")]
    public partial class MyCustomerChangeEmailAction : MyCustomerUpdateAction
    {
        public string Email { get; set;}
        public MyCustomerChangeEmailAction()
        { 
           this.Action = "changeEmail";
        }
    }
}

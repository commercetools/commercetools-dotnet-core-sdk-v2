using commercetools.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [DiscriminatorValue("changeEmail")]
    public partial class CustomerChangeEmailAction : CustomerUpdateAction
    {
        public string Email { get; set;}
        public CustomerChangeEmailAction()
        { 
           this.Action = "changeEmail";
        }
    }
}

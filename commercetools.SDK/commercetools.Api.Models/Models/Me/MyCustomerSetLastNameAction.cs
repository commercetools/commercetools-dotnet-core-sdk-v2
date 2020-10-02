using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("setLastName")]
    public partial class MyCustomerSetLastNameAction : MyCustomerUpdateAction
    {
        public string LastName { get; set;}
        public MyCustomerSetLastNameAction()
        { 
           this.Action = "setLastName";
        }
    }
}

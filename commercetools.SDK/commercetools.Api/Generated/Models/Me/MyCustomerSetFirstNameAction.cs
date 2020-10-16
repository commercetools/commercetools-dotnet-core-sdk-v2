using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("setFirstName")]
    public partial class MyCustomerSetFirstNameAction : MyCustomerUpdateAction
    {
        public string FirstName { get; set;}
        public MyCustomerSetFirstNameAction()
        { 
           this.Action = "setFirstName";
        }
    }
}

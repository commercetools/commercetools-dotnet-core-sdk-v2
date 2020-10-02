using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("setDateOfBirth")]
    public partial class MyCustomerSetDateOfBirthAction : MyCustomerUpdateAction
    {
        public DateTime DateOfBirth { get; set;}
        public MyCustomerSetDateOfBirthAction()
        { 
           this.Action = "setDateOfBirth";
        }
    }
}

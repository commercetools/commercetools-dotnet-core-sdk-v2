using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("setMiddleName")]
    public partial class MyCustomerSetMiddleNameAction : MyCustomerUpdateAction
    {
        public string MiddleName { get; set;}
        public MyCustomerSetMiddleNameAction()
        { 
           this.Action = "setMiddleName";
        }
    }
}

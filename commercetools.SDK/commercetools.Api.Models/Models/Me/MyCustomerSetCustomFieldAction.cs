using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("setCustomField")]
    public partial class MyCustomerSetCustomFieldAction : MyCustomerUpdateAction
    {
        public string Name { get; set;}
        
        public Object Value { get; set;}
        public MyCustomerSetCustomFieldAction()
        { 
           this.Action = "setCustomField";
        }
    }
}

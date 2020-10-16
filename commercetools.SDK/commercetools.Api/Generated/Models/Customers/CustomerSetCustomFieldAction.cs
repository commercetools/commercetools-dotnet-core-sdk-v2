using commercetools.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [DiscriminatorValue("setCustomField")]
    public partial class CustomerSetCustomFieldAction : CustomerUpdateAction
    {
        public string Name { get; set;}
        
        public Object Value { get; set;}
        public CustomerSetCustomFieldAction()
        { 
           this.Action = "setCustomField";
        }
    }
}

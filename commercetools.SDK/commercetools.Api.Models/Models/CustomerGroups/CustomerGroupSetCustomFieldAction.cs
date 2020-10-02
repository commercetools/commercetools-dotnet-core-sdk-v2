using commercetools.Api.Models.CustomerGroups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.CustomerGroups
{
    [DiscriminatorValue("setCustomField")]
    public partial class CustomerGroupSetCustomFieldAction : CustomerGroupUpdateAction
    {
        public string Name { get; set;}
        
        public Object Value { get; set;}
        public CustomerGroupSetCustomFieldAction()
        { 
           this.Action = "setCustomField";
        }
    }
}

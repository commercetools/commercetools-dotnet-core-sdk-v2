using commercetools.Api.Models.CustomerGroups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CustomerGroups
{
    [DiscriminatorValue("setKey")]
    public partial class CustomerGroupSetKeyAction : CustomerGroupUpdateAction
    {
        public string Key { get; set;}
        public CustomerGroupSetKeyAction()
        { 
           this.Action = "setKey";
        }
    }
}

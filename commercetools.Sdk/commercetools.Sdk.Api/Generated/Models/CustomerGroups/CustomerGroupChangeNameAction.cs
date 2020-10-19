using commercetools.Api.Models.CustomerGroups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CustomerGroups
{
    [DiscriminatorValue("changeName")]
    public partial class CustomerGroupChangeNameAction : CustomerGroupUpdateAction
    {
        public string Name { get; set;}
        public CustomerGroupChangeNameAction()
        { 
           this.Action = "changeName";
        }
    }
}

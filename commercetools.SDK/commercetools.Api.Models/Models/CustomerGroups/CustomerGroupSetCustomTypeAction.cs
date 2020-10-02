using commercetools.Api.Models.CustomerGroups;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.CustomerGroups
{
    [DiscriminatorValue("setCustomType")]
    public partial class CustomerGroupSetCustomTypeAction : CustomerGroupUpdateAction
    {
        public TypeResourceIdentifier Type { get; set;}
        
        public FieldContainer Fields { get; set;}
        public CustomerGroupSetCustomTypeAction()
        { 
           this.Action = "setCustomType";
        }
    }
}

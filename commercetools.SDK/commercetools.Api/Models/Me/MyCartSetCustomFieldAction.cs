using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("setCustomField")]
    public partial class MyCartSetCustomFieldAction : MyCartUpdateAction
    {
        public string Name { get; set;}
        
        public Object Value { get; set;}
        public MyCartSetCustomFieldAction()
        { 
           this.Action = "setCustomField";
        }
    }
}

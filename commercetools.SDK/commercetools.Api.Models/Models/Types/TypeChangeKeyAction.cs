using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    [DiscriminatorValue("changeKey")]
    public partial class TypeChangeKeyAction : TypeUpdateAction
    {
        public string Key { get; set;}
        public TypeChangeKeyAction()
        { 
           this.Action = "changeKey";
        }
    }
}

using commercetools.Api.Models.Common;
using commercetools.Api.Models.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Extensions
{
    public class ExtensionInput 
    {
        public string Action { get; set;}
        
        public ExtensionAction ActionAsEnum => this.Action.GetEnum<ExtensionAction>();
        
        public Reference Resource { get; set;}
    }
}

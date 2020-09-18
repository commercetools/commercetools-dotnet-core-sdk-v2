using commercetools.Api.Models.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Extensions
{
    public class ExtensionTrigger 
    {
        public string ResourceTypeId { get; set;}
        
        public ExtensionResourceTypeId ResourceTypeIdAsEnum => this.ResourceTypeId.GetEnum<ExtensionResourceTypeId>();
        
        public List<ExtensionAction> Actions { get; set;}
    }
}

using commercetools.Api.Generated.Models.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Extensions
{
    public interface IExtensionTrigger 
    {
        string ResourceTypeId { get; set;}
        
        ExtensionResourceTypeId ResourceTypeIdAsEnum { get; }
        
        List<string> Actions { get; set;}
        
        List<ExtensionAction> ActionsAsEnum { get; }
    }
}

using commercetools.Api.Generated.Models.Common;
using commercetools.Api.Generated.Models.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Extensions
{
    public interface IExtensionInput 
    {
        string Action { get; set;}
        
        ExtensionAction ActionAsEnum { get; }
        
        IReference Resource { get; set;}
    }
}

using commercetools.Api.Generated.Models.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Extensions
{
    public interface IExtensionDraft 
    {
        string Key { get; set;}
        
        IExtensionDestination Destination { get; set;}
        
        List<IExtensionTrigger> Triggers { get; set;}
        
        int TimeoutInMs { get; set;}
    }
}

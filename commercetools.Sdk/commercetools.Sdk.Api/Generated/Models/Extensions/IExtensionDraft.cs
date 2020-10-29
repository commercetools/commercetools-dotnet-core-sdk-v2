using commercetools.Api.Models.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Extensions
{
    [DeserializeAs(typeof(commercetools.Api.Models.Extensions.ExtensionDraft))]
    public interface IExtensionDraft 
    {
        string Key { get; set;}
        
        IExtensionDestination Destination { get; set;}
        
        List<IExtensionTrigger> Triggers { get; set;}
        
        int? TimeoutInMs { get; set;}
    }
}

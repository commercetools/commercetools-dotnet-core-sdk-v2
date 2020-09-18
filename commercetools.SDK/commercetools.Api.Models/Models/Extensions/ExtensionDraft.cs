using commercetools.Api.Models.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Extensions
{
    public class ExtensionDraft 
    {
        public string Key { get; set;}
        
        public ExtensionDestination Destination { get; set;}
        
        public List<ExtensionTrigger> Triggers { get; set;}
        
        public int TimeoutInMs { get; set;}
    }
}

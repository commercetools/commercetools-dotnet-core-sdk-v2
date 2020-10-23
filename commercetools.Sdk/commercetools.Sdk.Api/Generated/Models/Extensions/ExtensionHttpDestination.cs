using commercetools.Api.Models.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Extensions
{
    public  partial class ExtensionHttpDestination : IExtensionHttpDestination
    {
        public string Type { get; set;}
        
        public string Url { get; set;}
        
        public IExtensionHttpDestinationAuthentication Authentication { get; set;}
        public ExtensionHttpDestination()
        { 
           this.Type = "HTTP";
        }
    }
}

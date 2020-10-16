using commercetools.Api.Models.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Extensions
{
    [DiscriminatorValue("HTTP")]
    public partial class ExtensionHttpDestination : ExtensionDestination
    {
        public string Url { get; set;}
        
        public ExtensionHttpDestinationAuthentication Authentication { get; set;}
        public ExtensionHttpDestination()
        { 
           this.Type = "HTTP";
        }
    }
}

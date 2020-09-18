using commercetools.Api.Models.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Extensions
{
    [DiscriminatorValue("HTTP")]
    public class ExtensionHttpDestination : ExtensionDestination
    {
        public string Url { get; set;}
        
        public ExtensionHttpDestinationAuthentication Authentication { get; set;}
    }
}

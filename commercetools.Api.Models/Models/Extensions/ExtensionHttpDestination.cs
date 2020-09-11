using commercetools.Api.Models.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Extensions
{
    public class ExtensionHttpDestination : ExtensionDestination
    {
        public string Url { get; set;}
        
        public ExtensionHttpDestinationAuthentication Authentication { get; set;}
    }
}

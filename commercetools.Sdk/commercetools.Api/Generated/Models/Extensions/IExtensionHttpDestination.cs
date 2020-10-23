using commercetools.Api.Generated.Models.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Extensions
{
    public interface IExtensionHttpDestination : IExtensionDestination
    {
        string Url { get; set;}
        
        IExtensionHttpDestinationAuthentication Authentication { get; set;}
    }
}

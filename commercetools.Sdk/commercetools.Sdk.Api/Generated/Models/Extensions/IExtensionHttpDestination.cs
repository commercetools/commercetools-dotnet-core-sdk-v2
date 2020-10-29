using commercetools.Api.Models.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Extensions
{
    [DeserializeAs(typeof(commercetools.Api.Models.Extensions.ExtensionHttpDestination))]
    public interface IExtensionHttpDestination : IExtensionDestination
    {
        string Url { get; set;}
        
        IExtensionHttpDestinationAuthentication Authentication { get; set;}
    }
}

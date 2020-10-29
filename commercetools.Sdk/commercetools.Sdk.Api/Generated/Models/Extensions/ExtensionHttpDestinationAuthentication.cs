using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Extensions
{
    public abstract partial class ExtensionHttpDestinationAuthentication : IExtensionHttpDestinationAuthentication
    {
        public string Type { get; set;}
    }
}

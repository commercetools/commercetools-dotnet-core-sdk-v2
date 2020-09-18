using commercetools.Api.Models.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Extensions
{
    [DiscriminatorValue("AzureFunctions")]
    public class ExtensionAzureFunctionsAuthentication : ExtensionHttpDestinationAuthentication
    {
        public string Key { get; set;}
    }
}

using commercetools.Api.Models.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Extensions
{
    [DiscriminatorValue("AzureFunctions")]
    public partial class ExtensionAzureFunctionsAuthentication : ExtensionHttpDestinationAuthentication
    {
        public string Key { get; set;}
        public ExtensionAzureFunctionsAuthentication()
        { 
           this.Type = "AzureFunctions";
        }
    }
}

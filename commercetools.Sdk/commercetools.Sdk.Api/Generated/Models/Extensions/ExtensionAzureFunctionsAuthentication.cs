using commercetools.Api.Models.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Extensions
{
    public  partial class ExtensionAzureFunctionsAuthentication : IExtensionAzureFunctionsAuthentication
    {
        public string Type { get; set;}
        
        public string Key { get; set;}
        public ExtensionAzureFunctionsAuthentication()
        { 
           this.Type = "AzureFunctions";
        }
    }
}

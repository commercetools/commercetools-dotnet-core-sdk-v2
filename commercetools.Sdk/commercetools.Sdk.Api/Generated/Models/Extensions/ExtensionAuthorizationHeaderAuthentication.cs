using commercetools.Api.Models.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Extensions
{
    public  partial class ExtensionAuthorizationHeaderAuthentication : IExtensionAuthorizationHeaderAuthentication
    {
        public string Type { get; set;}
        
        public string HeaderValue { get; set;}
        public ExtensionAuthorizationHeaderAuthentication()
        { 
           this.Type = "AuthorizationHeader";
        }
    }
}

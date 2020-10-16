using commercetools.Api.Models.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Extensions
{
    [DiscriminatorValue("AuthorizationHeader")]
    public partial class ExtensionAuthorizationHeaderAuthentication : ExtensionHttpDestinationAuthentication
    {
        public string HeaderValue { get; set;}
        public ExtensionAuthorizationHeaderAuthentication()
        { 
           this.Type = "AuthorizationHeader";
        }
    }
}

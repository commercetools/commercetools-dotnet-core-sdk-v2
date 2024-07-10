using commercetools.Sdk.Api.Models.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Extensions
{

    public partial class AuthorizationHeaderAuthentication : IAuthorizationHeaderAuthentication
    {
        public string Type { get; set; }

        public string HeaderValue { get; set; }
        public AuthorizationHeaderAuthentication()
        {
            this.Type = "AuthorizationHeader";
        }
    }
}

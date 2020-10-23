using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Projects
{
    public  partial class ExternalOAuth : IExternalOAuth
    {
        public string Url { get; set;}
        
        public string AuthorizationHeader { get; set;}
    }
}

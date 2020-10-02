using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Projects
{
    public partial class ExternalOAuth 
    {
        public string Url { get; set;}
        
        public string AuthorizationHeader { get; set;}
    }
}

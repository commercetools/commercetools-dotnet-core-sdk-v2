using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Projects
{
    public class ExternalOAuth 
    {
        public string Url { get; set;}
        
        public string AuthorizationHeader { get; set;}
    }
}

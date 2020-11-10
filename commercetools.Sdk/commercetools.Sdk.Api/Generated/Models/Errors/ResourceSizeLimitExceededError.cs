using commercetools.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    public partial class ResourceSizeLimitExceededError : IResourceSizeLimitExceededError
    {
        public string Code { get; set;}
        
        public string Message { get; set;}
        public ResourceSizeLimitExceededError()
        { 
           this.Code = "ResourceSizeLimitExceeded";
        }
    }
}

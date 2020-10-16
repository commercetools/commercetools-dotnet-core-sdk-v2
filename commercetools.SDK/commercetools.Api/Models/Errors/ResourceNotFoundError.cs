using commercetools.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DiscriminatorValue("ResourceNotFound")]
    public partial class ResourceNotFoundError : ErrorObject
    {
        public ResourceNotFoundError()
        { 
           this.Code = "ResourceNotFound";
        }
    }
}

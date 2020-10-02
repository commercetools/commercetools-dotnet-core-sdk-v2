using commercetools.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DiscriminatorValue("access_denied")]
    public partial class AccessDeniedError : ErrorObject
    {
        public AccessDeniedError()
        { 
           this.Code = "access_denied";
        }
    }
}

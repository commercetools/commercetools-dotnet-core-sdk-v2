using commercetools.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


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

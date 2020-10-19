using commercetools.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DiscriminatorValue("invalid_token")]
    public partial class InvalidTokenError : ErrorObject
    {
        public InvalidTokenError()
        { 
           this.Code = "invalid_token";
        }
    }
}

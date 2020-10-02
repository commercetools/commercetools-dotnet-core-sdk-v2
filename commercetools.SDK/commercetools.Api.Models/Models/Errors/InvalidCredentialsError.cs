using commercetools.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DiscriminatorValue("InvalidCredentials")]
    public partial class InvalidCredentialsError : ErrorObject
    {
        public InvalidCredentialsError()
        { 
           this.Code = "InvalidCredentials";
        }
    }
}

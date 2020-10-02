using commercetools.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DiscriminatorValue("InvalidCurrentPassword")]
    public partial class InvalidCurrentPasswordError : ErrorObject
    {
        public InvalidCurrentPasswordError()
        { 
           this.Code = "InvalidCurrentPassword";
        }
    }
}

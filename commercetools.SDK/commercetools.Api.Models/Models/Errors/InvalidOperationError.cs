using commercetools.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DiscriminatorValue("InvalidOperation")]
    public partial class InvalidOperationError : ErrorObject
    {
        public InvalidOperationError()
        { 
           this.Code = "InvalidOperation";
        }
    }
}

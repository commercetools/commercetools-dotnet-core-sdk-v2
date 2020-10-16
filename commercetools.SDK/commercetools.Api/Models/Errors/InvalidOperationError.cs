using commercetools.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


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

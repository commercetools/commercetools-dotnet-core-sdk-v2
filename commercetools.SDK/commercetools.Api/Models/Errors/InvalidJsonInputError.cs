using commercetools.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DiscriminatorValue("InvalidJsonInput")]
    public partial class InvalidJsonInputError : ErrorObject
    {
        public InvalidJsonInputError()
        { 
           this.Code = "InvalidJsonInput";
        }
    }
}

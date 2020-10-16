using commercetools.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DiscriminatorValue("InvalidInput")]
    public partial class InvalidInputError : ErrorObject
    {
        public InvalidInputError()
        { 
           this.Code = "InvalidInput";
        }
    }
}

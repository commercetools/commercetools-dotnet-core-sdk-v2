using commercetools.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DiscriminatorValue("InvalidSubject")]
    public partial class InvalidSubjectError : ErrorObject
    {
        public InvalidSubjectError()
        { 
           this.Code = "InvalidSubject";
        }
    }
}

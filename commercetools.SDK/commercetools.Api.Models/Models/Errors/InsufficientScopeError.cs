using commercetools.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DiscriminatorValue("insufficient_scope")]
    public partial class InsufficientScopeError : ErrorObject
    {
        public InsufficientScopeError()
        { 
           this.Code = "insufficient_scope";
        }
    }
}

using commercetools.Api.Generated.Models.Common;
using commercetools.Api.Generated.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Errors
{
    public interface IDuplicateFieldError : IErrorObject
    {
        string Field { get; set;}
        
        Object DuplicateValue { get; set;}
        
        IReference ConflictingResource { get; set;}
    }
}

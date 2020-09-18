using commercetools.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DiscriminatorValue("InvalidField")]
    public class InvalidFieldError : ErrorObject
    {
        public string Field { get; set;}
        
        public Object InvalidValue { get; set;}
        
        public List<Object> AllowedValues { get; set;}
    }
}

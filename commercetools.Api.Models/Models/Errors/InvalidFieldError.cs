using commercetools.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Errors
{
    public class InvalidFieldError : ErrorObject
    {
        public string Field { get; set;}
        
        public Object InvalidValue { get; set;}
        
        public List<Object> AllowedValues { get; set;}
    }
}

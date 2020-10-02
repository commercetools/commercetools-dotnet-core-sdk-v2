using commercetools.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DiscriminatorValue("InvalidField")]
    public partial class InvalidFieldError : ErrorObject
    {
        public string Field { get; set;}
        
        public Object InvalidValue { get; set;}
        
        public List<Object> AllowedValues { get; set;}
        public InvalidFieldError()
        { 
           this.Code = "InvalidField";
        }
    }
}

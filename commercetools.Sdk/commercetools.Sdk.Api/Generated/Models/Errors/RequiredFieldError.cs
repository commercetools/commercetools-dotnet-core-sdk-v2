using commercetools.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    public partial class RequiredFieldError : IRequiredFieldError
    {
        public string Code { get; set;}
        
        public string Message { get; set;}
        
        public string Field { get; set;}
        public RequiredFieldError()
        { 
           this.Code = "RequiredField";
        }
    }
}

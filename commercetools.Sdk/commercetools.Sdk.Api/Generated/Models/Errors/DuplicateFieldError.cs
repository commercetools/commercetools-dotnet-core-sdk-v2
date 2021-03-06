using commercetools.Api.Models.Common;
using commercetools.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    public partial class DuplicateFieldError : IDuplicateFieldError
    {
        public string Code { get; set;}
        
        public string Message { get; set;}
        
        public string Field { get; set;}
        
        public Object DuplicateValue { get; set;}
        
        public IReference ConflictingResource { get; set;}
        public DuplicateFieldError()
        { 
           this.Code = "DuplicateField";
        }
    }
}

using commercetools.Api.Models.Common;
using commercetools.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DiscriminatorValue("DuplicateField")]
    public partial class DuplicateFieldError : ErrorObject
    {
        public string Field { get; set;}
        
        public Object DuplicateValue { get; set;}
        
        public Reference ConflictingResource { get; set;}
        public DuplicateFieldError()
        { 
           this.Code = "DuplicateField";
        }
    }
}

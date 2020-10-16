using commercetools.Api.Models.Common;
using commercetools.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DiscriminatorValue("DuplicateFieldWithConflictingResource")]
    public partial class DuplicateFieldWithConflictingResourceError : ErrorObject
    {
        public string Field { get; set;}
        
        public Object DuplicateValue { get; set;}
        
        public Reference ConflictingResource { get; set;}
        public DuplicateFieldWithConflictingResourceError()
        { 
           this.Code = "DuplicateFieldWithConflictingResource";
        }
    }
}

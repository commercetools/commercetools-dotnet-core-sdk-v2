using commercetools.Api.Models.Common;
using commercetools.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DiscriminatorValue("DuplicateFieldWithConflictingResource")]
    public class DuplicateFieldWithConflictingResourceError : ErrorObject
    {
        public string Field { get; set;}
        
        public Object DuplicateValue { get; set;}
        
        public Reference ConflictingResource { get; set;}
    }
}

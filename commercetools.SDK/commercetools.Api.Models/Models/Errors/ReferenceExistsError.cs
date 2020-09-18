using commercetools.Api.Models.Common;
using commercetools.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DiscriminatorValue("ReferenceExists")]
    public class ReferenceExistsError : ErrorObject
    {
        public string ReferencedBy { get; set;}
        
        public ReferenceTypeId ReferencedByAsEnum => this.ReferencedBy.GetEnum<ReferenceTypeId>();
    }
}

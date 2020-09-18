using commercetools.Api.Models.Common;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    [DiscriminatorValue("Reference")]
    public class CustomFieldReferenceType : FieldType
    {
        public string ReferenceTypeId { get; set;}
        
        public ReferenceTypeId ReferenceTypeIdAsEnum => this.ReferenceTypeId.GetEnum<ReferenceTypeId>();
    }
}

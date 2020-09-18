using commercetools.Api.Models.Common;
using commercetools.Api.Models.ProductTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [DiscriminatorValue("reference")]
    public class AttributeReferenceType : AttributeType
    {
        public string ReferenceTypeId { get; set;}
        
        public ReferenceTypeId ReferenceTypeIdAsEnum => this.ReferenceTypeId.GetEnum<ReferenceTypeId>();
    }
}

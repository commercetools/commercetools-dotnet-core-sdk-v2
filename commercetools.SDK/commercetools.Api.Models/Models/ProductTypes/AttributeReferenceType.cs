using commercetools.Api.Models.Common;
using commercetools.Api.Models.ProductTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [DiscriminatorValue("reference")]
    public partial class AttributeReferenceType : AttributeType
    {
        public string ReferenceTypeId { get; set;}
        
        [JsonIgnore]
        public ReferenceTypeId ReferenceTypeIdAsEnum => this.ReferenceTypeId.GetEnum<ReferenceTypeId>();
        public AttributeReferenceType()
        { 
           this.Name = "reference";
        }
    }
}

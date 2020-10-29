using commercetools.Api.Models.Common;
using commercetools.Api.Models.ProductTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    public partial class AttributeReferenceType : IAttributeReferenceType
    {
        public string Name { get; set;}
        
        public string ReferenceTypeId { get; set;}
        
        [JsonIgnore]
        public ReferenceTypeId ReferenceTypeIdAsEnum => this.ReferenceTypeId.GetEnum<ReferenceTypeId>();
        public AttributeReferenceType()
        { 
           this.Name = "reference";
        }
    }
}

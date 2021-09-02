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
        public string Name { get; set; }

        public IReferenceTypeId ReferenceTypeId { get; set; }
        public AttributeReferenceType()
        {
            this.Name = "reference";
        }
    }
}

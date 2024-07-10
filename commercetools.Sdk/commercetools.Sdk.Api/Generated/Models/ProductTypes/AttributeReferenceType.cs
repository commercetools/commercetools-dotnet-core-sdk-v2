using commercetools.Sdk.Api.Models.ProductTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.ProductTypes
{

    public partial class AttributeReferenceType : IAttributeReferenceType
    {
        public string Name { get; set; }

        public IAttributeReferenceTypeId ReferenceTypeId { get; set; }
        public AttributeReferenceType()
        {
            this.Name = "reference";
        }
    }
}

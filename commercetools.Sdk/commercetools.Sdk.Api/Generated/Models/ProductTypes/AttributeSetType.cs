using commercetools.Api.Models.ProductTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    public partial class AttributeSetType : IAttributeSetType
    {
        public string Name { get; set; }

        public IAttributeType ElementType { get; set; }
        public AttributeSetType()
        {
            this.Name = "set";
        }
    }
}

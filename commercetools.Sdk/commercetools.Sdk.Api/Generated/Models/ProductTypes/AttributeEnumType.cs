using commercetools.Sdk.Api.Models.ProductTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.ProductTypes
{

    public partial class AttributeEnumType : IAttributeEnumType
    {
        public string Name { get; set; }

        public IList<IAttributePlainEnumValue> Values { get; set; }
        public IEnumerable<IAttributePlainEnumValue> ValuesEnumerable { set => Values = value.ToList(); }

        public AttributeEnumType()
        {
            this.Name = "enum";
        }
    }
}

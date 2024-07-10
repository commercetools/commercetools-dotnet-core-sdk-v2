using commercetools.Sdk.ImportApi.Models.Producttypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.ImportApi.Models.Producttypes
{

    public partial class AttributeLocalizedEnumType : IAttributeLocalizedEnumType
    {
        public string Name { get; set; }

        public IList<IAttributeLocalizedEnumValue> Values { get; set; }
        public IEnumerable<IAttributeLocalizedEnumValue> ValuesEnumerable { set => Values = value.ToList(); }

        public AttributeLocalizedEnumType()
        {
            this.Name = "lenum";
        }
    }
}

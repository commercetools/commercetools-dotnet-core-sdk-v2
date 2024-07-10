using commercetools.Sdk.ImportApi.Models.Producttypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.ImportApi.Models.Producttypes
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    public abstract partial class AttributeType : IAttributeType
    {
        public string Name { get; set;}
    }
}

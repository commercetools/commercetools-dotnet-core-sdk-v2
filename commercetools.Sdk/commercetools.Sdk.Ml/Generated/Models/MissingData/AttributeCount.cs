using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Ml.Models.MissingData
{
    public partial class AttributeCount : IAttributeCount
    {
        public int ProductTypeAttributes { get; set;}
        
        public int VariantAttributes { get; set;}
        
        public int MissingAttributeValues { get; set;}
    }
}

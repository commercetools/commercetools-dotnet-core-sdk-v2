using commercetools.Ml.Models.Common;
using commercetools.Ml.Models.MissingData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Ml.Models.MissingData
{
    public partial class MissingAttributes : IMissingAttributes
    {
        public IProductReference Product { get; set;}
        
        public IProductTypeReference ProductType { get; set;}
        
        public int VariantId { get; set;}
        
        public List<string> MissingAttributeValues { get; set;}
        
        public List<string> MissingAttributeNames { get; set;}
        
        public IAttributeCount AttributeCount { get; set;}
        
        public IAttributeCoverage AttributeCoverage { get; set;}
    }
}

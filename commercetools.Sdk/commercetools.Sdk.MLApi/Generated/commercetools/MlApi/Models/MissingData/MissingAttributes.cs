using commercetools.MLApi.Models.Common;
using System.Collections.Generic;


namespace commercetools.MLApi.Models.MissingData
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

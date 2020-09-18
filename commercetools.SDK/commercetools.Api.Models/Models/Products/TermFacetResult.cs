using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DiscriminatorValue("terms")]
    public class TermFacetResult : FacetResult
    {
        public string DataType { get; set;}
        
        public TermFacetResultType DataTypeAsEnum => this.DataType.GetEnum<TermFacetResultType>();
        
        public long Missing { get; set;}
        
        public long Total { get; set;}
        
        public long Other { get; set;}
        
        public List<FacetResultTerm> Terms { get; set;}
    }
}

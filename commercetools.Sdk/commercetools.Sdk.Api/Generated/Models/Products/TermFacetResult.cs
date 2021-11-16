using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    public partial class TermFacetResult : ITermFacetResult
    {
        public IFacetTypes Type { get; set;}
        
        public ITermFacetResultType DataType { get; set;}
        
        public long Missing { get; set;}
        
        public long Total { get; set;}
        
        public long Other { get; set;}
        
        public List<IFacetResultTerm> Terms { get; set;}
        public TermFacetResult()
        { 
           this.Type = IFacetTypes.FindEnum("terms");
        }
    }
}

using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DiscriminatorValue("terms")]
    public partial class TermFacetResult : FacetResult
    {
        public string DataType { get; set;}
        
        [JsonIgnore]
        public TermFacetResultType DataTypeAsEnum => this.DataType.GetEnum<TermFacetResultType>();
        
        public long Missing { get; set;}
        
        public long Total { get; set;}
        
        public long Other { get; set;}
        
        public List<FacetResultTerm> Terms { get; set;}
        public TermFacetResult()
        { 
           this.Type = "terms";
        }
    }
}

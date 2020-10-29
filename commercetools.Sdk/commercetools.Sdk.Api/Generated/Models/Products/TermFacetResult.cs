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
        public string Type { get; set;}
        
        [JsonIgnore]
        public FacetTypes TypeAsEnum => this.Type.GetEnum<FacetTypes>();
        
        public string DataType { get; set;}
        
        [JsonIgnore]
        public TermFacetResultType DataTypeAsEnum => this.DataType.GetEnum<TermFacetResultType>();
        
        public long Missing { get; set;}
        
        public long Total { get; set;}
        
        public long Other { get; set;}
        
        public List<IFacetResultTerm> Terms { get; set;}
        public TermFacetResult()
        { 
           this.Type = "terms";
        }
    }
}

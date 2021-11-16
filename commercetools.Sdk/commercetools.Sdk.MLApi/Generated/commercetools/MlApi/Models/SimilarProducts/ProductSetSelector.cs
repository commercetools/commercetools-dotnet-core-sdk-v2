using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.MLApi.Models.SimilarProducts
{
    public partial class ProductSetSelector : IProductSetSelector
    {
        public string ProjectKey { get; set;}
        
        public List<string> ProductIds { get; set;}
        
        public List<string> ProductTypeIds { get; set;}
        
        public bool? Staged { get; set;}
        
        public bool? IncludeVariants { get; set;}
        
        public long? ProductSetLimit { get; set;}
    }
}

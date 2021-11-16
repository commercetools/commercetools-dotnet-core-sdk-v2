using commercetools.MLApi.Models.SimilarProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.MLApi.Models.SimilarProducts
{
    public partial class SimilarProductPair : ISimilarProductPair
    {
        public double Confidence { get; set;}
        
        public List<ISimilarProduct> Products { get; set;}
    }
}

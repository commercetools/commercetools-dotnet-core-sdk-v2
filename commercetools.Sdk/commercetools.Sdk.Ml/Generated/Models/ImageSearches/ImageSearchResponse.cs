using commercetools.Ml.Models.ImageSearches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Ml.Models.ImageSearches
{
    public partial class ImageSearchResponse : IImageSearchResponse
    {
        public int Count { get; set;}
        
        public double Offset { get; set;}
        
        public int Total { get; set;}
        
        public List<IResultItem> Results { get; set;}
    }
}

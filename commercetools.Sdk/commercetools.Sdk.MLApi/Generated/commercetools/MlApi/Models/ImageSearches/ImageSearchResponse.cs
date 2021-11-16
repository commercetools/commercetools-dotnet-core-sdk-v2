using System.Collections.Generic;


namespace commercetools.MLApi.Models.ImageSearches
{
    public partial class ImageSearchResponse : IImageSearchResponse
    {
        public int Count { get; set;}
        
        public double Offset { get; set;}
        
        public int Total { get; set;}
        
        public List<IResultItem> Results { get; set;}
    }
}

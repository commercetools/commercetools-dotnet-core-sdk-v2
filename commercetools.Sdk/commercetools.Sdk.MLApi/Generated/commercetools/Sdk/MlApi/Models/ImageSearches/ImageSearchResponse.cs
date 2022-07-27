using System.Collections.Generic;


namespace commercetools.Sdk.MLApi.Models.ImageSearches
{

    public partial class ImageSearchResponse : IImageSearchResponse
    {
        public int Count { get; set; }

        public decimal Offset { get; set; }

        public int Total { get; set; }

        public List<IResultItem> Results { get; set; }
    }
}

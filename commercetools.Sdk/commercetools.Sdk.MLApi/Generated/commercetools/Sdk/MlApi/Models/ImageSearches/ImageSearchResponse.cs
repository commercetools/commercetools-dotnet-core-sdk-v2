using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.MLApi.Models.ImageSearches
{

    public partial class ImageSearchResponse : IImageSearchResponse
    {
        public int Count { get; set; }

        public decimal Offset { get; set; }

        public int Total { get; set; }

        public IList<IResultItem> Results { get; set; }
        public IEnumerable<IResultItem> ResultsEnumerable { set => Results = value.ToList(); }

    }
}

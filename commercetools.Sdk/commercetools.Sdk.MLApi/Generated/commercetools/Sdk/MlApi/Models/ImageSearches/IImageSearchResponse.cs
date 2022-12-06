using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.MLApi.Models.ImageSearches
{
    [DeserializeAs(typeof(commercetools.Sdk.MLApi.Models.ImageSearches.ImageSearchResponse))]
    public partial interface IImageSearchResponse
    {
        int Count { get; set; }

        decimal Offset { get; set; }

        int Total { get; set; }

        IList<IResultItem> Results { get; set; }
        IEnumerable<IResultItem> ResultsEnumerable { set => Results = value.ToList(); }


    }
}

using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.MLApi.Models.ImageSearches
{
    [DeserializeAs(typeof(commercetools.MLApi.Models.ImageSearches.ImageSearchResponse))]
    public partial interface IImageSearchResponse
    {
        int Count { get; set; }

        double Offset { get; set; }

        int Total { get; set; }

        List<IResultItem> Results { get; set; }
    }
}

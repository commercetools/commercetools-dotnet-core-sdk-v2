using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.MLApi.Models.ImageSearches
{
    [DeserializeAs(typeof(commercetools.Sdk.MLApi.Models.ImageSearches.ImageSearchResponse))]
    public partial interface IImageSearchResponse
    {
        int Count { get; set; }

        double Offset { get; set; }

        int Total { get; set; }

        List<IResultItem> Results { get; set; }
    }
}

using commercetools.MLApi.Models.ImageSearches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
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

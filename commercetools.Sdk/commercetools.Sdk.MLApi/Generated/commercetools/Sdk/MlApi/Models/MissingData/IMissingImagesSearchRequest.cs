using System;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.MLApi.Models.MissingData
{
    [DeserializeAs(typeof(commercetools.Sdk.MLApi.Models.MissingData.MissingImagesSearchRequest))]
    [Obsolete]
    public partial interface IMissingImagesSearchRequest
    {
        long? Limit { get; set; }

        long? Offset { get; set; }

        bool? Staged { get; set; }

        long? ProductSetLimit { get; set; }

        bool? IncludeVariants { get; set; }

        bool? AutoThreshold { get; set; }

        long? Threshold { get; set; }

        List<string> ProductIds { get; set; }

        List<string> ProductTypeIds { get; set; }

    }
}

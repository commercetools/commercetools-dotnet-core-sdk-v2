using commercetools.MLApi.Models.MissingData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.MLApi.Models.MissingData
{
    [DeserializeAs(typeof(commercetools.MLApi.Models.MissingData.MissingImagesPagedQueryResult))]
    public partial interface IMissingImagesPagedQueryResult
    {
        long Count { get; set; }

        long Total { get; set; }

        long Offset { get; set; }

        List<IMissingImages> Results { get; set; }

        IMissingImagesMeta Meta { get; set; }
    }
}

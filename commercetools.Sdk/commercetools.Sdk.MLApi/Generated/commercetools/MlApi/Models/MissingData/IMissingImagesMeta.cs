using commercetools.MLApi.Models.MissingData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.MLApi.Models.MissingData
{
    [DeserializeAs(typeof(commercetools.MLApi.Models.MissingData.MissingImagesMeta))]
    public partial interface IMissingImagesMeta
    {
        IMissingImagesProductLevel ProductLevel { get; set; }

        IMissingImagesVariantLevel VariantLevel { get; set; }

        long Threshold { get; set; }
    }
}

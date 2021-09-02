using commercetools.MLApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.MLApi.Models.MissingData
{
    [DeserializeAs(typeof(commercetools.MLApi.Models.MissingData.MissingImages))]
    public partial interface IMissingImages
    {
        IProductReference Product { get; set; }

        long VariantId { get; set; }

        long ImageCount { get; set; }
    }
}

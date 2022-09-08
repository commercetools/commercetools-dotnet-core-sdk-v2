using System;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.MLApi.Models.MissingData
{
    [DeserializeAs(typeof(commercetools.Sdk.MLApi.Models.MissingData.MissingAttributesPagedQueryResult))]
    [Obsolete]
    public partial interface IMissingAttributesPagedQueryResult
    {
        long Count { get; set; }

        long Total { get; set; }

        long Offset { get; set; }

        List<IMissingAttributes> Results { get; set; }

        [ObsoleteAttribute("This property is obsolete", false)]
        IMissingAttributesMeta Meta { get; set; }

    }
}

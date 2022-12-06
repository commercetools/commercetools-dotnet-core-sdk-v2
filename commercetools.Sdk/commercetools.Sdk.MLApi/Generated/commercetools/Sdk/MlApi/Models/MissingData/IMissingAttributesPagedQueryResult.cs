using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.MLApi.Models.MissingData
{
    [DeserializeAs(typeof(commercetools.Sdk.MLApi.Models.MissingData.MissingAttributesPagedQueryResult))]
    public partial interface IMissingAttributesPagedQueryResult
    {
        long Count { get; set; }

        long Total { get; set; }

        long Offset { get; set; }

        IList<IMissingAttributes> Results { get; set; }
        IEnumerable<IMissingAttributes> ResultsEnumerable { set => Results = value.ToList(); }


        [ObsoleteAttribute("This property is obsolete", false)]
        IMissingAttributesMeta Meta { get; set; }

    }
}

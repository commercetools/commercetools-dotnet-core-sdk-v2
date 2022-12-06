using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.MLApi.Models.MissingData
{
    [DeserializeAs(typeof(commercetools.Sdk.MLApi.Models.MissingData.MissingImagesPagedQueryResult))]
    public partial interface IMissingImagesPagedQueryResult
    {
        long Count { get; set; }

        long Total { get; set; }

        long Offset { get; set; }

        IList<IMissingImages> Results { get; set; }
        IEnumerable<IMissingImages> ResultsEnumerable { set => Results = value.ToList(); }


        [ObsoleteAttribute("This property is obsolete", false)]
        IMissingImagesMeta Meta { get; set; }

    }
}

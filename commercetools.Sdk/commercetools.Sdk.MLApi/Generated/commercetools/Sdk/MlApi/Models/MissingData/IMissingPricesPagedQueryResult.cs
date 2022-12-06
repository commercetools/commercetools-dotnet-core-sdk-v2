using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.MLApi.Models.MissingData
{
    [DeserializeAs(typeof(commercetools.Sdk.MLApi.Models.MissingData.MissingPricesPagedQueryResult))]
    public partial interface IMissingPricesPagedQueryResult
    {
        long Count { get; set; }

        long Total { get; set; }

        long Offset { get; set; }

        IList<IMissingPrices> Results { get; set; }
        IEnumerable<IMissingPrices> ResultsEnumerable { set => Results = value.ToList(); }


        [ObsoleteAttribute("This property is obsolete", false)]
        IMissingPricesMeta Meta { get; set; }

    }
}

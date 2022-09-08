using System;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.MLApi.Models.MissingData
{
    [DeserializeAs(typeof(commercetools.Sdk.MLApi.Models.MissingData.MissingPricesPagedQueryResult))]
    [Obsolete]
    public partial interface IMissingPricesPagedQueryResult
    {
        long Count { get; set; }

        long Total { get; set; }

        long Offset { get; set; }

        List<IMissingPrices> Results { get; set; }

        [ObsoleteAttribute("This property is obsolete", false)]
        IMissingPricesMeta Meta { get; set; }

    }
}

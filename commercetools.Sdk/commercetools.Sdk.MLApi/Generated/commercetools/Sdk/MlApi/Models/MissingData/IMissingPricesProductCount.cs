using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.MLApi.Models.MissingData
{
    [DeserializeAs(typeof(commercetools.Sdk.MLApi.Models.MissingData.MissingPricesProductCount))]
    [Obsolete]
    public partial interface IMissingPricesProductCount
    {
        long Total { get; set; }

        long MissingPrices { get; set; }

    }
}

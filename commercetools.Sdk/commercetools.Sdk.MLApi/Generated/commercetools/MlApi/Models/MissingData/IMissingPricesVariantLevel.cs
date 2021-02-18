using commercetools.MLApi.Models.MissingData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.MLApi.Models.MissingData
{
    [DeserializeAs(typeof(commercetools.MLApi.Models.MissingData.MissingPricesVariantLevel))]
    public partial interface IMissingPricesVariantLevel : IMissingPricesProductCount
    {
        new long Total { get; set;}
        
        new long MissingPrices { get; set;}
    }
}

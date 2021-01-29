using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Ml.Models.MissingData
{
    [DeserializeAs(typeof(commercetools.Ml.Models.MissingData.MissingPricesProductCount))]
    public partial interface IMissingPricesProductCount 
    {
        long Total { get; set;}
        
        long MissingPrices { get; set;}
    }
}

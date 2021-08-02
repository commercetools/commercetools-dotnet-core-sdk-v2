using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Common.TaxedPrice))]
    public partial interface ITaxedPrice 
    {
        IMoney TotalNet { get; set;}
        
        IMoney TotalGross { get; set;}
    }
}

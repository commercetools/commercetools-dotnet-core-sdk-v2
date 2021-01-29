using commercetools.Ml.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Ml.Models.MissingData
{
    [DeserializeAs(typeof(commercetools.Ml.Models.MissingData.MissingPrices))]
    public partial interface IMissingPrices 
    {
        IProductReference Product { get; set;}
        
        long VariantId { get; set;}
    }
}

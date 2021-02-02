using commercetools.Ml.Models.MissingData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Ml.Models.MissingData
{
    public partial class MissingPricesMeta : IMissingPricesMeta
    {
        public IMissingPricesProductLevel ProductLevel { get; set;}
        
        public IMissingPricesVariantLevel VariantLevel { get; set;}
    }
}

using commercetools.Ml.Models.MissingData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Ml.Models.MissingData
{
    public partial class MissingPricesPagedQueryResult : IMissingPricesPagedQueryResult
    {
        public long Count { get; set;}
        
        public long Total { get; set;}
        
        public long Offset { get; set;}
        
        public List<IMissingPrices> Results { get; set;}
        
        public IMissingPricesMeta Meta { get; set;}
    }
}

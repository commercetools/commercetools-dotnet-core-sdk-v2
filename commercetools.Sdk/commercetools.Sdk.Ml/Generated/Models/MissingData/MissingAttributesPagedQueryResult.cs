using commercetools.Ml.Models.MissingData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Ml.Models.MissingData
{
    public partial class MissingAttributesPagedQueryResult : IMissingAttributesPagedQueryResult
    {
        public long Count { get; set;}
        
        public long Total { get; set;}
        
        public long Offset { get; set;}
        
        public List<IMissingAttributes> Results { get; set;}
        
        public IMissingAttributesMeta Meta { get; set;}
    }
}

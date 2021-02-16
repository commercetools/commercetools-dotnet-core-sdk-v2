using commercetools.Ml.Models.MissingData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Ml.Models.MissingData
{
    [DeserializeAs(typeof(commercetools.Ml.Models.MissingData.MissingAttributesPagedQueryResult))]
    public partial interface IMissingAttributesPagedQueryResult 
    {
        long Count { get; set;}
        
        long Total { get; set;}
        
        long Offset { get; set;}
        
        List<IMissingAttributes> Results { get; set;}
        
        IMissingAttributesMeta Meta { get; set;}
    }
}

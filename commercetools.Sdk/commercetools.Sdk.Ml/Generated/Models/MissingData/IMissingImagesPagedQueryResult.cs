using commercetools.Ml.Models.MissingData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Ml.Models.MissingData
{
    [DeserializeAs(typeof(commercetools.Ml.Models.MissingData.MissingImagesPagedQueryResult))]
    public partial interface IMissingImagesPagedQueryResult 
    {
        long Count { get; set;}
        
        long Total { get; set;}
        
        long Offset { get; set;}
        
        List<IMissingImages> Results { get; set;}
        
        IMissingImagesMeta Meta { get; set;}
    }
}

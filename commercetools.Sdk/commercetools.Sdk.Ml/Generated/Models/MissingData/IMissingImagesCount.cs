using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Ml.Models.MissingData
{
    [DeserializeAs(typeof(commercetools.Ml.Models.MissingData.MissingImagesCount))]
    public partial interface IMissingImagesCount 
    {
        long MissingImages { get; set;}
        
        long Total { get; set;}
    }
}

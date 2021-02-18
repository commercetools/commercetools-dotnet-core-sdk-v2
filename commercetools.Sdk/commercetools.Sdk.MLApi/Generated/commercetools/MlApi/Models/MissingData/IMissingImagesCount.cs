using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.MLApi.Models.MissingData
{
    [DeserializeAs(typeof(commercetools.MLApi.Models.MissingData.MissingImagesCount))]
    public partial interface IMissingImagesCount 
    {
        long MissingImages { get; set;}
        
        long Total { get; set;}
    }
}

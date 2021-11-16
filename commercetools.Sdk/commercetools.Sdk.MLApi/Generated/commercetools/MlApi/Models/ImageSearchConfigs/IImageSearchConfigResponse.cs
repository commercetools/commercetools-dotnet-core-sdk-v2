using commercetools.MLApi.Models.ImageSearchConfigs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.MLApi.Models.ImageSearchConfigs
{
    [DeserializeAs(typeof(commercetools.MLApi.Models.ImageSearchConfigs.ImageSearchConfigResponse))]
    public partial interface IImageSearchConfigResponse 
    {
        IImageSearchConfigStatus Status { get; set;}
        
        DateTime LastModifiedAt { get; set;}
    }
}

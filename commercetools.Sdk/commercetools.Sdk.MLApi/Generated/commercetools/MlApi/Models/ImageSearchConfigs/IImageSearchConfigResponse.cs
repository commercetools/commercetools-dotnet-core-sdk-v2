using System;
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

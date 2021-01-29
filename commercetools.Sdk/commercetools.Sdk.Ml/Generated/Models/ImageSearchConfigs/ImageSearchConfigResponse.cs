using commercetools.Ml.Models.ImageSearchConfigs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Ml.Models.ImageSearchConfigs
{
    public partial class ImageSearchConfigResponse : IImageSearchConfigResponse
    {
        public IImageSearchConfigStatus Status { get; set;}
        
        public DateTime LastModifiedAt { get; set;}
    }
}

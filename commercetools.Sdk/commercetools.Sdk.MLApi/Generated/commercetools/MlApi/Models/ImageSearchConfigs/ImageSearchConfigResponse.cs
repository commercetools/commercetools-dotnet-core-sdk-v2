using commercetools.MLApi.Models.ImageSearchConfigs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.MLApi.Models.ImageSearchConfigs
{
    public partial class ImageSearchConfigResponse : IImageSearchConfigResponse
    {
        public IImageSearchConfigStatus Status { get; set; }

        public DateTime LastModifiedAt { get; set; }
    }
}

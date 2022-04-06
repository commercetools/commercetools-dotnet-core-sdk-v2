using System;


namespace commercetools.Sdk.MLApi.Models.ImageSearchConfigs
{
    public partial class ImageSearchConfigResponse : IImageSearchConfigResponse
    {
        public IImageSearchConfigStatus Status { get; set; }

        public DateTime LastModifiedAt { get; set; }
    }
}

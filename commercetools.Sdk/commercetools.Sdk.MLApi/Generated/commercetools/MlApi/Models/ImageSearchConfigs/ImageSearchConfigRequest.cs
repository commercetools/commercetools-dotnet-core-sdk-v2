using System.Collections.Generic;


namespace commercetools.MLApi.Models.ImageSearchConfigs
{
    public partial class ImageSearchConfigRequest : IImageSearchConfigRequest
    {
        public List<IImageSearchConfigUpdateAction> Actions { get; set; }
    }
}

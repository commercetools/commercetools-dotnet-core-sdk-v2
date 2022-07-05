using System.Collections.Generic;


namespace commercetools.Sdk.MLApi.Models.ImageSearchConfigs
{

    public partial class ImageSearchConfigRequest : IImageSearchConfigRequest
    {
        public List<IImageSearchConfigUpdateAction> Actions { get; set; }
    }
}

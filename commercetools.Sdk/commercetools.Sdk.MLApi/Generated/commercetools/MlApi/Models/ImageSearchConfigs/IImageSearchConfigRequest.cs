using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.MLApi.Models.ImageSearchConfigs
{
    [DeserializeAs(typeof(commercetools.MLApi.Models.ImageSearchConfigs.ImageSearchConfigRequest))]
    public partial interface IImageSearchConfigRequest
    {
        List<IImageSearchConfigUpdateAction> Actions { get; set; }
    }
}

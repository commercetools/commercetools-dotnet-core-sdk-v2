using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.MLApi.Models.ImageSearchConfigs
{
    [DeserializeAs(typeof(commercetools.Sdk.MLApi.Models.ImageSearchConfigs.ImageSearchConfigRequest))]
    public partial interface IImageSearchConfigRequest
    {
        List<IImageSearchConfigUpdateAction> Actions { get; set; }
    }
}

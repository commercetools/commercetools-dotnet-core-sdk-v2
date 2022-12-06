using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.MLApi.Models.ImageSearchConfigs
{
    [DeserializeAs(typeof(commercetools.Sdk.MLApi.Models.ImageSearchConfigs.ImageSearchConfigRequest))]
    public partial interface IImageSearchConfigRequest
    {
        IList<IImageSearchConfigUpdateAction> Actions { get; set; }
        IEnumerable<IImageSearchConfigUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }


    }
}

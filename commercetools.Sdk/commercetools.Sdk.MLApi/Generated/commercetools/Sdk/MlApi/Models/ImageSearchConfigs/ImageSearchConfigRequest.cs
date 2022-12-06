using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.MLApi.Models.ImageSearchConfigs
{

    public partial class ImageSearchConfigRequest : IImageSearchConfigRequest
    {
        public IList<IImageSearchConfigUpdateAction> Actions { get; set; }
        public IEnumerable<IImageSearchConfigUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}

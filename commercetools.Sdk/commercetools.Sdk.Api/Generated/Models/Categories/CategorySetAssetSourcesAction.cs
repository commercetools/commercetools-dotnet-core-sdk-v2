using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Categories
{

    public partial class CategorySetAssetSourcesAction : ICategorySetAssetSourcesAction
    {
        public string Action { get; set; }

        public string AssetId { get; set; }

        public string AssetKey { get; set; }

        public List<IAssetSource> Sources { get; set; }
        public CategorySetAssetSourcesAction()
        {
            this.Action = "setAssetSources";
        }
    }
}

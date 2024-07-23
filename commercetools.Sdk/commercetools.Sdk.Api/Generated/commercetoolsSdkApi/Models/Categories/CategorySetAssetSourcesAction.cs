using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Categories
{

    public partial class CategorySetAssetSourcesAction : ICategorySetAssetSourcesAction
    {
        public string Action { get; set; }

        public string AssetId { get; set; }

        public string AssetKey { get; set; }

        public IList<IAssetSource> Sources { get; set; }
        public IEnumerable<IAssetSource> SourcesEnumerable { set => Sources = value.ToList(); }

        public CategorySetAssetSourcesAction()
        {
            this.Action = "setAssetSources";
        }
    }
}

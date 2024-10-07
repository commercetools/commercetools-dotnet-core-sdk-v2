using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Categories
{

    public partial class CategoryChangeAssetOrderAction : ICategoryChangeAssetOrderAction
    {
        public string Action { get; set; }

        public IList<string> AssetOrder { get; set; }

        public IEnumerable<string> AssetOrderEnumerable { set => AssetOrder = value.ToList(); }
        public CategoryChangeAssetOrderAction()
        {
            this.Action = "changeAssetOrder";
        }
    }
}

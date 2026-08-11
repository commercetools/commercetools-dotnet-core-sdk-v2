using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Variants
{

    public partial class VariantChangeAssetOrderAction : IVariantChangeAssetOrderAction
    {
        public string Action { get; set; }

        public bool? Staged { get; set; }

        public IList<string> AssetOrder { get; set; }

        public IEnumerable<string> AssetOrderEnumerable { set => AssetOrder = value.ToList(); }
        public VariantChangeAssetOrderAction()
        {
            this.Action = "changeAssetOrder";
        }
    }
}

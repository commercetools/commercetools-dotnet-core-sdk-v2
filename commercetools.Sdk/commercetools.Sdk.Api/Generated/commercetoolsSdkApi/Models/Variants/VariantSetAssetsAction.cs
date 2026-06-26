using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Variants
{

    public partial class VariantSetAssetsAction : IVariantSetAssetsAction
    {
        public string Action { get; set; }

        public IList<IAssetDraft> Assets { get; set; }

        public IEnumerable<IAssetDraft> AssetsEnumerable { set => Assets = value.ToList(); }

        public bool? Staged { get; set; }
        public VariantSetAssetsAction()
        {
            this.Action = "setAssets";
        }
    }
}

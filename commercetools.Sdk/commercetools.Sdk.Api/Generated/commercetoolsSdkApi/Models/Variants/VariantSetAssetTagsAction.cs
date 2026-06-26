using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Variants
{

    public partial class VariantSetAssetTagsAction : IVariantSetAssetTagsAction
    {
        public string Action { get; set; }

        public bool? Staged { get; set; }

        public string AssetId { get; set; }

        public string AssetKey { get; set; }

        public IList<string> Tags { get; set; }

        public IEnumerable<string> TagsEnumerable { set => Tags = value.ToList(); }
        public VariantSetAssetTagsAction()
        {
            this.Action = "setAssetTags";
        }
    }
}

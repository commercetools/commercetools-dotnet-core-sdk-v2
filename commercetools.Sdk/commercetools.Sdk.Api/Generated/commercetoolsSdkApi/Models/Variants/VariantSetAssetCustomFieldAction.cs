using System;

namespace commercetools.Sdk.Api.Models.Variants
{

    public partial class VariantSetAssetCustomFieldAction : IVariantSetAssetCustomFieldAction
    {
        public string Action { get; set; }

        public bool? Staged { get; set; }

        public string AssetId { get; set; }

        public string AssetKey { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public VariantSetAssetCustomFieldAction()
        {
            this.Action = "setAssetCustomField";
        }
    }
}

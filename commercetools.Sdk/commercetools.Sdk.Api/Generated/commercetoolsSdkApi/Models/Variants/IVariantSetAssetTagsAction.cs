using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Variants
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Variants.VariantSetAssetTagsAction))]
    public partial interface IVariantSetAssetTagsAction : IVariantUpdateAction
    {
        bool? Staged { get; set; }

        string AssetId { get; set; }

        string AssetKey { get; set; }

        IList<string> Tags { get; set; }

        IEnumerable<string> TagsEnumerable { set => Tags = value.ToList(); }

    }
}

using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Categories
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Categories.CategorySetAssetTagsAction))]
    public partial interface ICategorySetAssetTagsAction : ICategoryUpdateAction
    {
        string AssetId { get; set; }

        string AssetKey { get; set; }

        IList<string> Tags { get; set; }

        IEnumerable<string> TagsEnumerable { set => Tags = value.ToList(); }

    }
}

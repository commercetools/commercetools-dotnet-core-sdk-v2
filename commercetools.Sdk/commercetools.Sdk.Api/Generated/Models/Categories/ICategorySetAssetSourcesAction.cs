using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Categories
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Categories.CategorySetAssetSourcesAction))]
    public partial interface ICategorySetAssetSourcesAction : ICategoryUpdateAction
    {
        string AssetId { get; set; }

        string AssetKey { get; set; }

        IList<IAssetSource> Sources { get; set; }
        IEnumerable<IAssetSource> SourcesEnumerable { set => Sources = value.ToList(); }


    }
}

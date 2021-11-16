using commercetools.Api.Models.Common;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Categories
{
    [DeserializeAs(typeof(commercetools.Api.Models.Categories.CategorySetAssetSourcesAction))]
    public partial interface ICategorySetAssetSourcesAction : ICategoryUpdateAction
    {
        string AssetId { get; set; }

        string AssetKey { get; set; }

        List<IAssetSource> Sources { get; set; }
    }
}

using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Categories
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Categories.CategoryChangeAssetOrderAction))]
    public partial interface ICategoryChangeAssetOrderAction : ICategoryUpdateAction
    {
        IList<string> AssetOrder { get; set; }
        IEnumerable<string> AssetOrderEnumerable { set => AssetOrder = value.ToList(); }


    }
}

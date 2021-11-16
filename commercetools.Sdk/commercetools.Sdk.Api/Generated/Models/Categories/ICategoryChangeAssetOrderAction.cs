using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Categories
{
    [DeserializeAs(typeof(commercetools.Api.Models.Categories.CategoryChangeAssetOrderAction))]
    public partial interface ICategoryChangeAssetOrderAction : ICategoryUpdateAction
    {
        List<string> AssetOrder { get; set;}
    }
}

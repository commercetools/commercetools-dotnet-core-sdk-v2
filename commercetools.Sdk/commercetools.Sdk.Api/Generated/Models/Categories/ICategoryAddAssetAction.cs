using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Categories
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Categories.CategoryAddAssetAction))]
    public partial interface ICategoryAddAssetAction : ICategoryUpdateAction
    {
        IAssetDraft Asset { get; set; }

        int? Position { get; set; }

    }
}

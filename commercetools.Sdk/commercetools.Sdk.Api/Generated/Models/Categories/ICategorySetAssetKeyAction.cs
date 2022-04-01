using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Categories
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Categories.CategorySetAssetKeyAction))]
    public partial interface ICategorySetAssetKeyAction : ICategoryUpdateAction
    {
        string AssetId { get; set; }

        string AssetKey { get; set; }
    }
}

using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Categories
{
    [DeserializeAs(typeof(commercetools.Api.Models.Categories.CategorySetAssetKeyAction))]
    public partial interface ICategorySetAssetKeyAction : ICategoryUpdateAction
    {
        string AssetId { get; set; }

        string AssetKey { get; set; }
    }
}

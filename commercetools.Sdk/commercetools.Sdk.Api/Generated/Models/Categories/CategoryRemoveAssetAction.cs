namespace commercetools.Api.Models.Categories
{
    public partial class CategoryRemoveAssetAction : ICategoryRemoveAssetAction
    {
        public string Action { get; set; }

        public string AssetId { get; set; }

        public string AssetKey { get; set; }
        public CategoryRemoveAssetAction()
        {
            this.Action = "removeAsset";
        }
    }
}

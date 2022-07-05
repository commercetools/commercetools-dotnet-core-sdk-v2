namespace commercetools.Sdk.Api.Models.Categories
{

    public partial class CategorySetAssetKeyAction : ICategorySetAssetKeyAction
    {
        public string Action { get; set; }

        public string AssetId { get; set; }

        public string AssetKey { get; set; }
        public CategorySetAssetKeyAction()
        {
            this.Action = "setAssetKey";
        }
    }
}

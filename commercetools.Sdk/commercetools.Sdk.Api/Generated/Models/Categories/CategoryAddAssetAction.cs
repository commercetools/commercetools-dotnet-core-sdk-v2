using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Categories
{

    public partial class CategoryAddAssetAction : ICategoryAddAssetAction
    {
        public string Action { get; set; }

        public IAssetDraft Asset { get; set; }

        public int? Position { get; set; }
        public CategoryAddAssetAction()
        {
            this.Action = "addAsset";
        }
    }
}

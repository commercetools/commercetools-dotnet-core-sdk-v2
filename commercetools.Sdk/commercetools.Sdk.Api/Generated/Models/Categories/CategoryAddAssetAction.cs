using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Categories
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

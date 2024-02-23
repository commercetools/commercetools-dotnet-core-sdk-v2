using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Categories
{

    public partial class CategoryChangeAssetNameAction : ICategoryChangeAssetNameAction
    {
        public string Action { get; set; }

        public string AssetId { get; set; }

        public string AssetKey { get; set; }

        public ILocalizedString Name { get; set; }
        public CategoryChangeAssetNameAction()
        {
            this.Action = "changeAssetName";
        }
    }
}

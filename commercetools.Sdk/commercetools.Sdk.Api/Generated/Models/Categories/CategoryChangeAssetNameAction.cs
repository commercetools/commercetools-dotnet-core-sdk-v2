using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Categories
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

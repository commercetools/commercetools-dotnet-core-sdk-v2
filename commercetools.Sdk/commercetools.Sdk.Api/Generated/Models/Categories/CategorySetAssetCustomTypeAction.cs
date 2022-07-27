using commercetools.Sdk.Api.Models.Types;


namespace commercetools.Sdk.Api.Models.Categories
{

    public partial class CategorySetAssetCustomTypeAction : ICategorySetAssetCustomTypeAction
    {
        public string Action { get; set; }

        public string AssetId { get; set; }

        public string AssetKey { get; set; }

        public ITypeResourceIdentifier Type { get; set; }

        public IFieldContainer Fields { get; set; }
        public CategorySetAssetCustomTypeAction()
        {
            this.Action = "setAssetCustomType";
        }
    }
}

using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.ProductTailorings
{

    public partial class ProductTailoringSetMetaTitleAction : IProductTailoringSetMetaTitleAction
    {
        public string Action { get; set; }

        public ILocalizedString MetaTitle { get; set; }

        public bool? Staged { get; set; }
        public ProductTailoringSetMetaTitleAction()
        {
            this.Action = "setMetaTitle";
        }
    }
}

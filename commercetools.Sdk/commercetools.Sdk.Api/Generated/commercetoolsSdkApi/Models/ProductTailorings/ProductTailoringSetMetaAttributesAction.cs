using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.ProductTailorings
{

    public partial class ProductTailoringSetMetaAttributesAction : IProductTailoringSetMetaAttributesAction
    {
        public string Action { get; set; }

        public ILocalizedString MetaTitle { get; set; }

        public ILocalizedString MetaDescription { get; set; }

        public ILocalizedString MetaKeywords { get; set; }

        public bool? Staged { get; set; }
        public ProductTailoringSetMetaAttributesAction()
        {
            this.Action = "setMetaAttributes";
        }
    }
}

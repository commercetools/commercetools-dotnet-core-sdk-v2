using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.ProductTailorings
{

    public partial class ProductTailoringSetMetaKeywordsAction : IProductTailoringSetMetaKeywordsAction
    {
        public string Action { get; set; }

        public ILocalizedString MetaKeywords { get; set; }

        public bool? Staged { get; set; }
        public ProductTailoringSetMetaKeywordsAction()
        {
            this.Action = "setMetaKeywords";
        }
    }
}

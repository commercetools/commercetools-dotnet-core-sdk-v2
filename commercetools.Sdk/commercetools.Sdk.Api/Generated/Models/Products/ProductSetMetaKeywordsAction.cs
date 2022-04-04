using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Products
{
    public partial class ProductSetMetaKeywordsAction : IProductSetMetaKeywordsAction
    {
        public string Action { get; set; }

        public ILocalizedString MetaKeywords { get; set; }

        public bool? Staged { get; set; }
        public ProductSetMetaKeywordsAction()
        {
            this.Action = "setMetaKeywords";
        }
    }
}

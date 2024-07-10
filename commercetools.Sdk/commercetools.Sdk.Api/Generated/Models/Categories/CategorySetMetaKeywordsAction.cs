using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Categories
{

    public partial class CategorySetMetaKeywordsAction : ICategorySetMetaKeywordsAction
    {
        public string Action { get; set; }

        public ILocalizedString MetaKeywords { get; set; }
        public CategorySetMetaKeywordsAction()
        {
            this.Action = "setMetaKeywords";
        }
    }
}

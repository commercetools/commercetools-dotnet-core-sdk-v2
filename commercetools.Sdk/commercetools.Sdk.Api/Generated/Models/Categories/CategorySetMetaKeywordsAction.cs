using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Categories
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

using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Categories
{
    public partial class CategorySetMetaTitleAction : ICategorySetMetaTitleAction
    {
        public string Action { get; set; }

        public ILocalizedString MetaTitle { get; set; }
        public CategorySetMetaTitleAction()
        {
            this.Action = "setMetaTitle";
        }
    }
}

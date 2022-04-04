using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Categories
{
    public partial class CategorySetMetaDescriptionAction : ICategorySetMetaDescriptionAction
    {
        public string Action { get; set; }

        public ILocalizedString MetaDescription { get; set; }
        public CategorySetMetaDescriptionAction()
        {
            this.Action = "setMetaDescription";
        }
    }
}

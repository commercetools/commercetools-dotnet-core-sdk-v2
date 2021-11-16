using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Categories
{
    public partial class CategoryChangeSlugAction : ICategoryChangeSlugAction
    {
        public string Action { get; set; }

        public ILocalizedString Slug { get; set; }
        public CategoryChangeSlugAction()
        {
            this.Action = "changeSlug";
        }
    }
}

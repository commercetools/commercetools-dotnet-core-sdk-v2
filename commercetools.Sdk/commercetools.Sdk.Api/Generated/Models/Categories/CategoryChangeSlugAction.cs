using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Categories
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

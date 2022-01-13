using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Categories
{
    public partial class CategorySetDescriptionAction : ICategorySetDescriptionAction
    {
        public string Action { get; set; }

        public ILocalizedString Description { get; set; }
        public CategorySetDescriptionAction()
        {
            this.Action = "setDescription";
        }
    }
}

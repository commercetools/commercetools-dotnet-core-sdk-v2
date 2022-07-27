using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Categories
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

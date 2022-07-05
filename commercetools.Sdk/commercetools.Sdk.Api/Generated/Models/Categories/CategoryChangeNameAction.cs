using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Categories
{

    public partial class CategoryChangeNameAction : ICategoryChangeNameAction
    {
        public string Action { get; set; }

        public ILocalizedString Name { get; set; }
        public CategoryChangeNameAction()
        {
            this.Action = "changeName";
        }
    }
}

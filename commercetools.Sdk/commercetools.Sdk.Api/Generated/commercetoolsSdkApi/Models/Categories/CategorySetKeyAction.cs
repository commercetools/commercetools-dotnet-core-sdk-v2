

namespace commercetools.Sdk.Api.Models.Categories
{

    public partial class CategorySetKeyAction : ICategorySetKeyAction
    {
        public string Action { get; set; }

        public string Key { get; set; }
        public CategorySetKeyAction()
        {
            this.Action = "setKey";
        }
    }
}

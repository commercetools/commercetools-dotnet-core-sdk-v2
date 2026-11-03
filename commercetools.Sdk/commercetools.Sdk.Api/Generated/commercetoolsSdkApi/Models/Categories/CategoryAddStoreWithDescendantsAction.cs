using commercetools.Sdk.Api.Models.Stores;


namespace commercetools.Sdk.Api.Models.Categories
{

    public partial class CategoryAddStoreWithDescendantsAction : ICategoryAddStoreWithDescendantsAction
    {
        public string Action { get; set; }

        public IStoreResourceIdentifier Store { get; set; }
        public CategoryAddStoreWithDescendantsAction()
        {
            this.Action = "addStoreWithDescendants";
        }
    }
}

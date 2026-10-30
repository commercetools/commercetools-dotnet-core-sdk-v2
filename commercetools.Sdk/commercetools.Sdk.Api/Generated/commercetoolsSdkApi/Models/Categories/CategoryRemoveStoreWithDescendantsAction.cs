using commercetools.Sdk.Api.Models.Stores;


namespace commercetools.Sdk.Api.Models.Categories
{

    public partial class CategoryRemoveStoreWithDescendantsAction : ICategoryRemoveStoreWithDescendantsAction
    {
        public string Action { get; set; }

        public IStoreResourceIdentifier Store { get; set; }
        public CategoryRemoveStoreWithDescendantsAction()
        {
            this.Action = "removeStoreWithDescendants";
        }
    }
}

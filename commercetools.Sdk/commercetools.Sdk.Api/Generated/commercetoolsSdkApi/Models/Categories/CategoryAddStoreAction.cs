using commercetools.Sdk.Api.Models.Stores;


namespace commercetools.Sdk.Api.Models.Categories
{

    public partial class CategoryAddStoreAction : ICategoryAddStoreAction
    {
        public string Action { get; set; }

        public IStoreResourceIdentifier Store { get; set; }
        public CategoryAddStoreAction()
        {
            this.Action = "addStore";
        }
    }
}

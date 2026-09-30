using commercetools.Sdk.Api.Models.Stores;


namespace commercetools.Sdk.Api.Models.Categories
{

    public partial class CategoryRemoveStoreAction : ICategoryRemoveStoreAction
    {
        public string Action { get; set; }

        public IStoreResourceIdentifier Store { get; set; }
        public CategoryRemoveStoreAction()
        {
            this.Action = "removeStore";
        }
    }
}

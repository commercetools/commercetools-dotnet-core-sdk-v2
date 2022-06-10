using commercetools.Sdk.Api.Models.ProductSelections;


namespace commercetools.Sdk.Api.Models.Stores
{
    public partial class StoreRemoveProductSelectionAction : IStoreRemoveProductSelectionAction
    {
        public string Action { get; set; }

        public IProductSelectionResourceIdentifier ProductSelection { get; set; }
        public StoreRemoveProductSelectionAction()
        {
            this.Action = "removeProductSelection";
        }
    }
}

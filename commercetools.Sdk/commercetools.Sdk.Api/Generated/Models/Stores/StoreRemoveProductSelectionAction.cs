using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Stores
{
    public partial class StoreRemoveProductSelectionAction : IStoreRemoveProductSelectionAction
    {
        public string Action { get; set; }

        public IResourceIdentifier ProductSelection { get; set; }
        public StoreRemoveProductSelectionAction()
        {
            this.Action = "removeProductSelection";
        }
    }
}

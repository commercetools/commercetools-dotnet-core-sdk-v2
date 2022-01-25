using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Stores
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

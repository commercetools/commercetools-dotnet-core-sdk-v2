using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Stores
{
    public partial class StoreChangeProductSelectionAction : IStoreChangeProductSelectionAction
    {
        public string Action { get; set; }

        public IResourceIdentifier ProductSelection { get; set; }

        public bool? Active { get; set; }
        public StoreChangeProductSelectionAction()
        {
            this.Action = "changeProductSelectionActive";
        }
    }
}
